using BuildingBlocks.CQRS;
using FluentValidation;
using Product.Grpc;
using ProductionPlanning.API.Dtos;

namespace ProductionPlanning.API.ProductionPlanning.InsertProduct
{
    public record ProductCommand(ProductDto Product)
    : ICommand<ProductResult>;
    public record ProductResult(int Id);

    public class ProductCommandValidator
        : AbstractValidator<ProductCommand>
    {
        public ProductCommandValidator()
        {

        }
    }
    public class InsertProductHandler
        (ProductProtoService.ProductProtoServiceClient productDto)
    : ICommandHandler<ProductCommand, ProductResult>
    {
        public async Task<ProductResult> Handle(ProductCommand request, CancellationToken cancellationToken)
        {
            var result = await productDto.CreateProductAsync(new CreateProductRequest()
            {
                Product = new ProductModel()
                {
                    ProductCode01 = request.Product.ProductCode01,
                    ProductCode02 = request.Product.ProductCode02 == null? string.Empty:request.Product.ProductCode02,
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
            return new ProductResult(result.Id);
        }
    }
}
