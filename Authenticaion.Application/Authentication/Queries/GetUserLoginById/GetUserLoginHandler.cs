using Authenticaion.Application.Authentication.Queries.GetUserInfosById;
using Authenticaion.Application.Exceptions;
using Authentication.Domain.ValueObjects;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Authenticaion.Application.Authentication.Queries.GetUserLogin
{
    public class GetUserLoginHandler(IApplicationDbContext dbContext)
     : IQueryHandler<GetUserLoginQuery, GetUserLoginResult>
    {
        public async Task<GetUserLoginResult> Handle(GetUserLoginQuery query, CancellationToken cancellationToken)
        {
            UserLoginDto result = new UserLoginDto(query.UserInfo.UserName, "", "", "", "", "");

            if (!string.IsNullOrEmpty(query.UserInfo.UserName) &&
                !string.IsNullOrEmpty(query.UserInfo.Password))
            {
                var userInfoDetail = await dbContext.UserInfoDetails.Where
                    (x => x.AccountName == query.UserInfo.UserName
                && x.Password == query.UserInfo.Password).FirstOrDefaultAsync();


                if (userInfoDetail is null)
                {
                    throw new ArgumentException(query.UserInfo.UserName);
                }
                var user = await dbContext.UserInfos.FindAsync(
                    [userInfoDetail.UserInfoId], cancellationToken: cancellationToken);


                var claims = new[]
                {
                    new Claim(ClaimTypes.NameIdentifier, userInfoDetail.AccountCode),
                    new Claim(ClaimTypes.GivenName, user.FullName),
                    new Claim(ClaimTypes.Surname, user.FullName),                   
                    new Claim(ClaimTypes.Role, "Standard")
                    };

                var token = new JwtSecurityToken
                (
                    issuer: query.UserInfo.Issuer,
                    audience: query.UserInfo.Audience,
                    claims: claims,
                    expires: DateTime.UtcNow.AddDays(60),
                    notBefore: DateTime.UtcNow,
                    signingCredentials: new SigningCredentials(
                        new SymmetricSecurityKey(Encoding.UTF8.GetBytes(query.UserInfo.Key)),
                        SecurityAlgorithms.HmacSha256)
                );

                var tokenString = new JwtSecurityTokenHandler().WriteToken(token);
                result = new UserLoginDto(query.UserInfo.UserName, "", "", "", "", tokenString);
            }

            return new GetUserLoginResult(result);
        }
    }
}
