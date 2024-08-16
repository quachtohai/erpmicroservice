using BuildingBlocks.Pagination;
using BuildingBlocks.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authenticaion.Application.Authentication.Queries.SearchUserInfos
{

        public record SearchUserInfosQuery(SearchRequest Param)
            : IQuery<SearchUserInfosResult>;

        public record SearchUserInfosResult(SearchResult<UserInfoDto> Results);
    
}
