using BuildingBlocks.CQRS;
using FluentValidation;
using Product.Grpc;
using ProductionPlanning.API.Dtos;

namespace ProductionPlanning.API.ProductionPlanning.UpdateProduct
{
    public record ProductCommand(ProductDto Product)
    : ICommand<ProductResult>;
    public record ProductResult(bool IsSuccess);

    public class ProductCommandValidator
        : AbstractValidator<ProductCommand>
    {
        public ProductCommandValidator()
        {

        }
    }
    public class UpdateProductHandler
        (ProductProtoService.ProductProtoServiceClient ProductDto)
    : ICommandHandler<ProductCommand, ProductResult>
    {
        public async Task<ProductResult> Handle(ProductCommand request, CancellationToken cancellationToken)
        {
            var result = await ProductDto.UpdateProductAsync(new Product.Grpc.UpdateProductRequest()
            {
                Product = new ProductModel()
                {
                    Id = request.Product.Id,
                    ProductCode01 = request.Product.ProductCode01,
                    ProductCode02 = request.Product.ProductCode02,
                    ProductName = request.Product.ProductName,
                    Description = request.Product.Description,
                    IsActive = true,
                    Description2 = string.Empty,
                    Description3 = string.Empty,
                    Description4 = string.Empty,
                    Description5 = string.Empty,
                    Description6 = string.Empty,
                    Process = request.Product.Process


                }
            }, cancellationToken: cancellationToken);
            return new ProductResult(true);
        }


    }
}
