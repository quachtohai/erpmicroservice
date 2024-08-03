using Authentication.Domain.Models;
using Authentication.Domain.ValueObjects;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Authenticaion.Application.Authentication.Commands.CreateUserInfo
{
    public class CreateUserInfoHandler(IApplicationDbContext dbContext)
     : ICommandHandler<CreateUserInfoCommand, CreateUserInfoResult>
    {
        public async Task<CreateUserInfoResult> Handle(CreateUserInfoCommand command, CancellationToken cancellationToken)
        {
            

            var userInfo = CreateNewUserInfo(command.UserInfo);

            dbContext.UserInfos.Add(userInfo);
            await dbContext.SaveChangesAsync(cancellationToken);

            return new CreateUserInfoResult(userInfo.Id.Value);
        }

        private UserInfo CreateNewUserInfo(UserInfoDto userInfoDto)
        {


            var newUserInfo = UserInfo.Create(
                    id: UserInfoId.Of(Guid.NewGuid()),
                    userInfoCode: userInfoDto.UserInfoCode,
                    firstName: userInfoDto.FirstName,
                    lastName: userInfoDto.LastName,
                    fullName: userInfoDto.FullName,
                    birthDate: userInfoDto.BirthDate,
                    year:userInfoDto.Year
                    );

            foreach (var userInfoItemDto in userInfoDto.UserInfoDetails)
            {
                newUserInfo.Add(userInfoItemDto.AccountCode, userInfoItemDto.AccountName, userInfoItemDto.Password, userInfoItemDto.FacultyDetail);
            }
            return newUserInfo;
        }
    }
}
