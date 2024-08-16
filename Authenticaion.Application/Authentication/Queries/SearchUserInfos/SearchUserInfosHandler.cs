using Authentication.Domain.Models;
using BuildingBlocks.Search;

namespace Authenticaion.Application.Authentication.Queries.SearchUserInfos
{
    public class SearchUserInfosHandler(IApplicationDbContext dbContext)
     : IQueryHandler<SearchUserInfosQuery, SearchUserInfosResult>
    {
        public async Task<SearchUserInfosResult> Handle(SearchUserInfosQuery query, CancellationToken cancellationToken)
        {

            var q = query.Param.Q;
            var fields = query.Param.Fields;

            List<UserInfo> userInfos = new List<UserInfo>();

            await dbContext.UserInfos.ForEachAsync(info => {
                if(q.Equals(string.Empty) ||info.GetType().GetProperty(fields).GetValue(info, null).ToString().Contains(q.ToString()))
                    userInfos.Add(info);
            });                           
                           

            return new SearchUserInfosResult(
                new SearchResult<UserInfoDto>(
                    true, "Search UserInfo successfully ",
                    userInfos.ToUserInfoDtoList()));
        }
    }
}
