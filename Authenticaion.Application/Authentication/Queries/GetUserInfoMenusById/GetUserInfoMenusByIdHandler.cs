using Authenticaion.Application.Authentication.Queries.GetUserInfosById;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authenticaion.Application.Authentication.Queries.GetUserInfoMenusById
{
    public class GetUserInfoMenusByIdHandler(IApplicationDbContext dbContext)
     : IQueryHandler<GetUserInfoMenusByIdQuery, GetUserInfoMenusByIdResult>
    {
        public async Task<GetUserInfoMenusByIdResult> Handle(GetUserInfoMenusByIdQuery query, CancellationToken cancellationToken)
        {
            Guid key = query.UserInfoId;
            var userInfo = dbContext.UserInfos
                            .Include(i=>i.ItemMenus)
                            .AsNoTracking()
                            .ToList()
                            .Where(o => o.Id.Value == key);


            return new GetUserInfoMenusByIdResult(userInfo.ToUserInfoDtoList().FirstOrDefault());
        }
    }
}
