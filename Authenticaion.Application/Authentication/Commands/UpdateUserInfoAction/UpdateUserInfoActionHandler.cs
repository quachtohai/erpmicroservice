using Authenticaion.Application.Authentication.Commands.UpdateUserInfoMenu;
using Authenticaion.Application.Exceptions;
using Authentication.Domain.Models;
using Authentication.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authenticaion.Application.Authentication.Commands.UpdateUserInfoAction
{
    public class UpdateUserInfoActionHandler(IApplicationDbContext dbContext)
      : ICommandHandler<UpdateUserInfoActionCommand, UpdateUserInfoActionResult>
    {
        public async Task<UpdateUserInfoActionResult> Handle(UpdateUserInfoActionCommand command, CancellationToken cancellationToken)
        {

            var userInfoId = UserInfoId.Of(command.UserInfo.Id);
            var user = await dbContext.UserInfos
                .FindAsync([userInfoId], cancellationToken: cancellationToken);

            if (user is null)
            {
                throw new UserNotFoundException(command.UserInfo.Id);
            }

            var userInfoMenus = dbContext.UserInfoActions.Where(x => x.UserInfoId == userInfoId).ToList();
            foreach (var action in userInfoMenus)
            {
                dbContext.UserInfoActions.Remove(action);
                await dbContext.SaveChangesAsync(cancellationToken);
            }

            if (command.UserInfo.UserInfoActions is not null && command.UserInfo.UserInfoActions.Count() > 0)
            {
                foreach (var userInfoActionCommand in command.UserInfo.UserInfoActions)
                {
                    var action = await dbContext.ActionInfos.FindAsync([ActionInfoId.Of(userInfoActionCommand.Id)],
                        cancellationToken: cancellationToken);
                    if (action is not null)
                    {
                        UserInfoAction actionInfo = new UserInfoAction(userInfoId, action.Id,action.ActionCode,
                            action.ModuleCode, action.Name);
                        dbContext.UserInfoActions.Add(actionInfo);
                        await dbContext.SaveChangesAsync(cancellationToken);
                    }
                }
            }

            return new UpdateUserInfoActionResult(true);
        }


    }
}
