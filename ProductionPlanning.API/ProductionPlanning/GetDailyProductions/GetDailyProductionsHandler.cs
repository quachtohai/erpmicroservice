using BuildingBlocks.CQRS;
using BuildingBlocks.Pagination;
using Microsoft.EntityFrameworkCore;
using ProductionPlanning.API.Data;
using ProductionPlanning.API.Dtos;
using ProductionPlanning.API.Extensions;
using ProductionPlanning.API.Models;

namespace ProductionPlanning.API.ProductionPlanning.GetDailyProductions
{
    public record GetDailyProductionsQuery(PaginationRequestWithDate PaginationRequest)
        : IQuery<GetDailyProductionsResult>;

    public record GetDailyProductionsResult(PaginatedResult<DailyProductionDto> Results);

    public class GetDailyProductionsHandler(ProductionPlanningContext dbContext)
    : IQueryHandler<GetDailyProductionsQuery, GetDailyProductionsResult>
    {
        public async Task<GetDailyProductionsResult> Handle(GetDailyProductionsQuery query, CancellationToken cancellationToken)
        {

            var pageIndex = query.PaginationRequest.PageIndex;
            var pageSize = query.PaginationRequest.PageSize;
            var filter = query.PaginationRequest.Filter;
            var equal = query.PaginationRequest.Equal;
            var q = query.PaginationRequest.Q;
            var fields = query.PaginationRequest.Fields;

            var filterId = filter + "Id";
            var fromDate = query.PaginationRequest.FromDate;
            var toDate = query.PaginationRequest.ToDate;
            var totalCount = await dbContext.DailyProductions.LongCountAsync(cancellationToken);


            var dailyProductionFinals = new List<DailyProduction>();
            if (!string.IsNullOrEmpty(filter) && equal != "")
            {
                string[] filterTmp = filter.Split(',');
                foreach (var filterItem in filterTmp)
                {
                    await dbContext.DailyProductions
                    .ForEachAsync(dailyProduction =>
                    {
                        if (dailyProduction.GetType().GetProperty(filterItem).GetValue(dailyProduction).ToString().Contains(equal.ToString()))

                        {
                            dailyProductionFinals.Add(dailyProduction);
                        }
                    });

                }

            }
            else if (!string.IsNullOrEmpty(fields) && q != "")
            {
                string[] fieldsTmp = fields.Split(',');
                foreach (var fieldTmpItem in fieldsTmp)
                {
                    await dbContext.DailyProductions
                    .ForEachAsync(dailyProduction =>
                    {
                        if (dailyProduction.GetType().GetProperty(fieldTmpItem).GetValue(dailyProduction)
                        .ToString().Contains(q.ToString()))

                        {
                            dailyProductionFinals.Add(dailyProduction);
                        }
                    });

                }
            }
            else
            {
                dailyProductionFinals = await dbContext.DailyProductions

                           .OrderByDescending(o => o.Date)
                           .Skip(pageSize * (pageIndex - 1))
                           .Take(pageSize)
                           .ToListAsync(cancellationToken);
            }
            return new GetDailyProductionsResult(
                new PaginatedResult<DailyProductionDto>(
                    pageIndex,
                    pageSize,
                    totalCount,
                    dailyProductionFinals.ToDailyProductionDtoList()));
        }
    }
}
