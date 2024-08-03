
using Grpc.Core;
using Mapster;
using Item.API.Data;
using Item.API.Models;

using Material.Grpc;
using Microsoft.EntityFrameworkCore;

namespace Item.API.Items
{
    public class MaterialService
    (ItemContext dbContext, ILogger<MaterialService> logger)
    : MaterialProtoService.MaterialProtoServiceBase
    {
        public override async Task<MaterialModel> GetMaterial(GetMaterialRequest request, ServerCallContext context)
        {
            var material = await dbContext
                .MaterialInfos
                .FirstOrDefaultAsync(x => x.MaterialName == request.MateritalName);

            if (material is null)
                material = new MaterialInfo { MaterialName = "No Material", Description = "No Material" };

            logger.LogInformation("MaterialInfo is retrieved for MaterialName : {materialName}, Description : {description}",
                material.MaterialName, material.Description);

            var materialModel = material.Adapt<MaterialModel>();
            return materialModel;
        }


    }

}
