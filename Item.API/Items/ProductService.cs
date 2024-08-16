using Grpc.Core;
using Item.API.Data;
using Mapster;
using Material.Grpc;
using Microsoft.EntityFrameworkCore;
using Product.Grpc;

namespace Item.API.Items
{
    public class ProductService
     (ItemContext dbContext, ILogger<ProductService> logger)
     : ProductProtoService.ProductProtoServiceBase
    {
        public override async Task<ProductModelList> GetProduct(GetProductRequest request, ServerCallContext context)
        {
            
            var products = await dbContext
                .Products
                .Where(x=>string.IsNullOrEmpty(request.ProductName) || x.ProductName.Contains(request.ProductName))
                .ToListAsync();
            List<ProductModel> productModels = new List<ProductModel>();
            products.ForEach(product =>
            {

                var productModel = product.Adapt<ProductModel>();
                productModels.Add(productModel);


            });
            ProductModelList result = new ProductModelList();
            result.Product.AddRange(productModels);

            return result;
        }

        

        public override async Task<ProductModel> GetProductByName(GetProductRequestByName request, ServerCallContext context)
        {
            var product = await dbContext
                .Products.Where(x=> string.IsNullOrEmpty(request.Name)||
                x.ProductName.Contains(request.Name)).ToListAsync();

            var productModel = product.Adapt<ProductModel>();
            return productModel;

        }



        public override async Task<ProductModel> CreateProduct(CreateProductRequest request, ServerCallContext context)
        {
            var product = request.Product.Adapt<Models.Product>();
            if (product is null)
                throw new RpcException(new Status(StatusCode.InvalidArgument, "Invalid request object."));

            dbContext.Products.Add(product);
            await dbContext.SaveChangesAsync();

            logger.LogInformation("Product is successfully created. ProductName : {ProductName}", product.ProductName);

            var productModel = product.Adapt<ProductModel>();
            productModel.Id = product.Id;
            return productModel;
        }

        public override async Task<ProductModel> UpdateProduct(UpdateProductRequest request, ServerCallContext context)
        {
            var product = request.Product.Adapt<Models.Product>();
            if (product is null)
                throw new RpcException(new Status(StatusCode.InvalidArgument, "Invalid request object."));

            dbContext.Products.Update(product);
            await dbContext.SaveChangesAsync();

            logger.LogInformation("Product is successfully updated. Product : {ProductName}", product.ProductName);

            var productModel = product.Adapt<ProductModel>();
            return productModel;
        }
        public override async Task<DeleteProductResponse> DeleteProduct(DeleteProductRequest request, ServerCallContext context)
        {
            var product = await dbContext
                .Products
                .FirstOrDefaultAsync(x => x.Id == request.Id);

            if (product is null)
                throw new RpcException(new Status(StatusCode.NotFound, $"Product with ProductId={request.Id} is not found."));

            dbContext.Products.Remove(product);
            await dbContext.SaveChangesAsync();

            logger.LogInformation("Product is successfully deleted. ProductId : {ProductId}", request.Id);

            return new DeleteProductResponse { Success = true };
        }
    }

}
