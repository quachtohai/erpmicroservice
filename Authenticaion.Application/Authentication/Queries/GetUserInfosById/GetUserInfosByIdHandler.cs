using System.Linq;

namespace Authenticaion.Application.Authentication.Queries.GetUserInfosById
{
    public class GetUserInfosByIdHandler(IApplicationDbContext dbContext)
     : IQueryHandler<GetUserInfosByIdQuery, GetUserInfosByIdResult>
    {
        public async Task<GetUserInfosByIdResult> Handle(GetUserInfosByIdQuery query, CancellationToken cancellationToken)
        {
            Guid key = query.UserInfoId;
            var userInfo =  dbContext.UserInfos
                            .Include(o => o.Items)
                            .AsNoTracking()
                            .ToList()
                            .Where(o => o.Id.Value == key);
                            

            return new GetUserInfosByIdResult(userInfo.ToUserInfoDtoList().FirstOrDefault());
        }
    }
}
