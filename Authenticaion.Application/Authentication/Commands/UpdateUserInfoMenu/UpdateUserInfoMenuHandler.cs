using Authenticaion.Application.Authentication.Commands.UpdateUserInfo;
using Authenticaion.Application.Exceptions;
using Authentication.Domain.Models;
using Authentication.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authenticaion.Application.Authentication.Commands.UpdateUserInfoMenu
{
    public class UpdateUserInfoMenuHandler(IApplicationDbContext dbContext)
     : ICommandHandler<UpdateUserInfoMenuCommand, UpdateUserInfoMenuResult>
    {
        public async Task<UpdateUserInfoMenuResult> Handle(UpdateUserInfoMenuCommand command, CancellationToken cancellationToken)
        {

            var userInfoId = UserInfoId.Of(command.UserInfo.Id);
            var user = await dbContext.UserInfos
                .FindAsync([userInfoId], cancellationToken: cancellationToken);

            if (user is null)
            {
                throw new UserNotFoundException(command.UserInfo.Id);
            }

            var userInfoMenus = dbContext.UserInfoMenus.Where(x => x.UserInfoId == userInfoId).ToList();
            foreach (var menu in userInfoMenus)
            {
                dbContext.UserInfoMenus.Remove(menu);
                await dbContext.SaveChangesAsync(cancellationToken);
            }

            if (command.UserInfo.UserInfoMenus is not null && command.UserInfo.UserInfoMenus.Count() > 0)
            {
                foreach (var userInfoMenuCommand in command.UserInfo.UserInfoMenus)
                {
                    var menu = await dbContext.Menus.FindAsync([MenuId.Of(userInfoMenuCommand.Id)],
                        cancellationToken: cancellationToken);
                    if (menu is not null)
                    {
                        UserInfoMenu userInfo = new UserInfoMenu(userInfoId, menu.Id, menu.MenuCode, menu.Name);
                        dbContext.UserInfoMenus.Add(userInfo);
                        await dbContext.SaveChangesAsync(cancellationToken);
                    }
                }
            }

            return new UpdateUserInfoMenuResult(true);
        }


    }
}
