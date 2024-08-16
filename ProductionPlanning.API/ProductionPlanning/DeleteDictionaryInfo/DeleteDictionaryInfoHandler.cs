using BuildingBlocks.CQRS;
using DictionaryInfo.Grpc;
using FluentValidation;

namespace ProductionPlanning.API.ProductionPlanning.DeleteDictionaryInfo
{
    public record DictionaryInfoCommand(int DictionaryInfoId)
     : ICommand<DictionaryInfoResult>;
    public record DictionaryInfoResult(bool IsSuccess);

    public class DictionaryInfoCommandValidator
        : AbstractValidator<DictionaryInfoCommand>
    {
        public DictionaryInfoCommandValidator()
        {

        }
    }
    public class DeleteDictionaryInfoHandler
        (DictionaryInfoProtoService.DictionaryInfoProtoServiceClient dictionaryInfoDto)
    : ICommandHandler<DictionaryInfoCommand, DictionaryInfoResult>
    {
        public async Task<DictionaryInfoResult> Handle(DictionaryInfoCommand request, CancellationToken cancellationToken)
        {
            var result = await dictionaryInfoDto.DeleteDictionaryInfoAsync(new DeleteDictionaryInfoRequest()
            {
                Id = request.DictionaryInfoId,
            }, cancellationToken: cancellationToken);
            return new DictionaryInfoResult(true);

        }
    }
}
