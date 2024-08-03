using Authenticaion.Application.Authentication.Queries.GetUserInfoMenusById;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authenticaion.Application.Authentication.Queries.GetUserInfoActionsById
{
    public class GetUserInfoActionsByIdHandler(IApplicationDbContext dbContext)
     : IQueryHandler<GetUserInfoActionsByIdQuery, GetUserInfoActionsByIdResult>
    {
        public async Task<GetUserInfoActionsByIdResult> Handle
            (GetUserInfoActionsByIdQuery query, CancellationToken cancellationToken)
        {
            Guid key = query.UserInfoId;
            var userInfo = dbContext.UserInfos
                            .Include(i => i.ItemActions)
                            .AsNoTracking()
                            .ToList()
                            .Where(o => o.Id.Value == key);


            return new GetUserInfoActionsByIdResult(userInfo.ToUserInfoDtoList().FirstOrDefault());
        }
    }
}
