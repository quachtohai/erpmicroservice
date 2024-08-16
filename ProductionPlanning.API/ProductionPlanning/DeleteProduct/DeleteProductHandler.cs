using BuildingBlocks.CQRS;
using FluentValidation;
using Product.Grpc;

namespace ProductionPlanning.API.ProductionPlanning.DeleteProduct
{
    public record ProductCommand(int ProductId)
     : ICommand<ProductResult>;
    public record ProductResult(bool IsSuccess);

    public class ProductCommandValidator
        : AbstractValidator<ProductCommand>
    {
        public ProductCommandValidator()
        {

        }
    }
    public class DeleteProductHandler
        (ProductProtoService.ProductProtoServiceClient ProductDto)
    : ICommandHandler<ProductCommand, ProductResult>
    {
        public async Task<ProductResult> Handle(ProductCommand request, CancellationToken cancellationToken)
        {
            var result = await ProductDto.DeleteProductAsync(new DeleteProductRequest()
            {
                Id = request.ProductId,
            }, cancellationToken: cancellationToken);
            return new ProductResult(true);

        }
    }
}
