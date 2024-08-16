using Authenticaion.Application.Exceptions;
using Authentication.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authenticaion.Application.Authentication.Commands.DeleteUserInfo
{
    public class DeleteUserInfoHandler(IApplicationDbContext dbContext)
     : ICommandHandler<DeleteUserInfoCommand, DeleteUserInfoResult>
    {
        public async Task<DeleteUserInfoResult> Handle(DeleteUserInfoCommand command, CancellationToken cancellationToken)
        {

            var userInfoId = UserInfoId.Of(command.UserInfoId);
            var user = await dbContext.UserInfos
                .FindAsync([userInfoId], cancellationToken: cancellationToken);

            if (user is null)
            {
                throw new UserNotFoundException(command.UserInfoId);
            }

            user.IsDeleted = true;
            dbContext.UserInfos.Update(user);
            await dbContext.SaveChangesAsync(cancellationToken);

            return new DeleteUserInfoResult(true);
        }
    }
}
