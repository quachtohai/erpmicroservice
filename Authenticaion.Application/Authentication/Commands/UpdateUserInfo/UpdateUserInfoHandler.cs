using Authenticaion.Application.Exceptions;
using Authentication.Domain.Models;
using Authentication.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Authenticaion.Application.Authentication.Commands.UpdateUserInfo
{
    public class UpdateUserInfoHandler(IApplicationDbContext dbContext)
     : ICommandHandler<UpdateUserInfoCommand, UpdateUserInfoResult>
    {
        public async Task<UpdateUserInfoResult> Handle(UpdateUserInfoCommand command, CancellationToken cancellationToken)
        {

            var userInfoId = UserInfoId.Of(command.UserInfo.Id);
            var user = await dbContext.UserInfos
                .FindAsync([userInfoId], cancellationToken: cancellationToken);

            if (user is null)
            {
                throw new UserNotFoundException(command.UserInfo.Id);
            }
            var userDetails =  dbContext.UserInfoDetails.ToListAsync().
                Result.Where(x=>x.UserInfoId==userInfoId);
            if (userDetails is null)
            {
                throw new UserNotFoundException(command.UserInfo.Id);
            }
            UpdateUserInfoWithNewValues(user, command.UserInfo);

            dbContext.UserInfos.Update(user);
            foreach(var userInfoDetail in userDetails)
            {
                var userInfoDetailNewValue = command.UserInfo.UserInfoDetails.Where(x=>x.Id == userInfoDetail.Id.Value).FirstOrDefault();
                if (userInfoDetailNewValue is not null)
                {
                    UpdateUserInfoDetailWithNewValues(userInfoDetail, userInfoDetailNewValue);
                    dbContext.UserInfoDetails.Update(userInfoDetail);
                    await dbContext.SaveChangesAsync(cancellationToken);
                }
               
            }
            foreach (var userInfoDetailCommand in command.UserInfo.UserInfoDetails)
            {
                if (userDetails.Where(x=>x.Id.Value== userInfoDetailCommand.Id).FirstOrDefault() is null)
                {
                    UserInfoDetail userInfoDetailAddNew = AddUserInfoDetailWithNewValues(userInfoDetailCommand);
                    dbContext.UserInfoDetails.Add(userInfoDetailAddNew);
                    await dbContext.SaveChangesAsync(cancellationToken);
                }
            }
            await dbContext.SaveChangesAsync(cancellationToken);

            return new UpdateUserInfoResult(true);
        }

        public void UpdateUserInfoWithNewValues(UserInfo userInfo, UserInfoDto userInfoDto)
        {

           
            userInfo.Update(userInfoDto.UserInfoCode, userInfoDto.FirstName, userInfoDto.LastName, userInfoDto.FullName,
                userInfoDto.BirthDate, userInfoDto.Year);

        }

        public void UpdateUserInfoDetailWithNewValues(UserInfoDetail userInfoDetail, UserInfoDetailDto userInfoDetailDto)
        {
            
            userInfoDetail.AccountCode = userInfoDetailDto.AccountCode;     
            userInfoDetail.AccountName = userInfoDetailDto.AccountName;     
            userInfoDetail.Password = userInfoDetailDto.Password;     
            userInfoDetail.FacultyDetail = userInfoDetailDto.FacultyDetail;
            
        }

        public UserInfoDetail AddUserInfoDetailWithNewValues(
            UserInfoDetailDto userInfoDetailDto)
        {
            UserInfoDetail userInfoDetail  = new UserInfoDetail(
                UserInfoDetailId.Of(Guid.NewGuid()), UserInfoId.Of(userInfoDetailDto.UserInfoId),
                userInfoDetailDto.AccountCode, userInfoDetailDto.AccountName, userInfoDetailDto.Password, userInfoDetailDto.FacultyDetail);

            return userInfoDetail;
        }
    }

}
