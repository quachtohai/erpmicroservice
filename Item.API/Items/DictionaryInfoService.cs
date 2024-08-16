using DictionaryInfo.Grpc;
using Grpc.Core;
using Item.API.Data;
using Mapster;
using Microsoft.EntityFrameworkCore;

namespace Item.API.Items
{
    public class DictionaryInfoService
     (ItemContext dbContext, ILogger<DictionaryInfoService> logger)
     : DictionaryInfoProtoService.DictionaryInfoProtoServiceBase
    {
        public override async Task<DictionaryInfoModelList> GetDictionaryInfo(GetDictionaryInfoRequest request, ServerCallContext context)
        {
            var dictionaryInfos = await dbContext
                .DictionaryInfos
                .ToListAsync();
            List<DictionaryInfoModel> dictionaryInfoModels = new List<DictionaryInfoModel>();
            dictionaryInfos.ForEach(dictionaryInfo =>
            {

                var dictionaryInfoModel = dictionaryInfo.Adapt<DictionaryInfoModel>();
                dictionaryInfoModels.Add(dictionaryInfoModel);


            });
            DictionaryInfoModelList result = new DictionaryInfoModelList();
            result.Dictionaryinfo.AddRange(dictionaryInfoModels);

            return result;
        }

        public override async Task<DictionaryInfoModel> GetDictionaryInfoById(GetDictionaryInfoRequestById request, ServerCallContext context)
        {
            var dictionaryInfo = await dbContext
                .DictionaryInfos.
                FindAsync([request.Id]);

            var dictionaryInfoModel = dictionaryInfo.Adapt<DictionaryInfoModel>();
            return dictionaryInfoModel;

        }

        public override async Task<DictionaryInfoModel> CreateDictionaryInfo(CreateDictionaryInfoRequest request, ServerCallContext context)
        {
            var dictionaryInfo = request.DictionaryInfo.Adapt<Models.DictionaryInfo>();
            if (dictionaryInfo is null)
                throw new RpcException(new Status(StatusCode.InvalidArgument, "Invalid request object."));

            dbContext.DictionaryInfos.Add(dictionaryInfo);
            await dbContext.SaveChangesAsync();

            logger.LogInformation("DictionaryInfo is successfully created. DictionaryInfoName : {DictionaryInfoName}", dictionaryInfo.DictionaryInfoName);

            var dictionaryInfoModel = dictionaryInfo.Adapt<DictionaryInfoModel>();
            dictionaryInfoModel.Id = dictionaryInfo.Id;
            return dictionaryInfoModel;
        }

        public override async Task<DictionaryInfoModel> UpdateDictionaryInfo(UpdateDictionaryInfoRequest request, ServerCallContext context)
        {
            var dictionaryInfo = request.DictionaryInfo.Adapt<Models.DictionaryInfo>();
            if (dictionaryInfo is null)
                throw new RpcException(new Status(StatusCode.InvalidArgument, "Invalid request object."));

            dbContext.DictionaryInfos.Update(dictionaryInfo);
            await dbContext.SaveChangesAsync();

            logger.LogInformation("DictionaryInfo is successfully updated. DictionaryInfo : {DictionaryInfoName}", dictionaryInfo.DictionaryInfoName);

            var dictionaryInfoModel = dictionaryInfo.Adapt<DictionaryInfoModel>();
            return dictionaryInfoModel;
        }
        public override async Task<DeleteDictionaryInfoResponse> DeleteDictionaryInfo(DeleteDictionaryInfoRequest request, ServerCallContext context)
        {
            var dictionaryInfo = await dbContext
                .DictionaryInfos
                .FirstOrDefaultAsync(x => x.Id == request.Id);

            if (dictionaryInfo is null)
                throw new RpcException(new Status(StatusCode.NotFound, $"Dictionary with DictionaryId={request.Id} is not found."));

            dbContext.DictionaryInfos.Remove(dictionaryInfo);
            await dbContext.SaveChangesAsync();

            logger.LogInformation("Dictionary is successfully deleted. DictionaryInfoName : {DictionaryInfoId}", request.Id);

            return new DeleteDictionaryInfoResponse { Success = true };
        }


    }
}
