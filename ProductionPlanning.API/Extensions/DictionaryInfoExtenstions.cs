using DictionaryInfo.Grpc;
using ProductionPlanning.API.Dtos;

namespace ProductionPlanning.API.Extensions
{
    public static class DictionaryInfoExtenstions
    {

        public static IEnumerable<DictionaryInfoDto> ToDictionaryInfoDtoList(this IEnumerable<DictionaryInfoModel> dictionaryInfos)
        {
            return dictionaryInfos.Select(dictionaryInfo => new DictionaryInfoDto(
              Id: dictionaryInfo.Id,
              DictionaryInfoCode: dictionaryInfo.DictionaryInfoCode,
              DictionaryInfoName: dictionaryInfo.DictionaryInfoName,
              Description: dictionaryInfo.Description,
              Process: dictionaryInfo.Process
            ));
        }
    }
}
