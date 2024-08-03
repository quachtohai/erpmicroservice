namespace Authenticaion.Application.Authentication.Queries.GetUserInfosById
{
    public record GetUserInfosByIdQuery(Guid UserInfoId)
    : IQuery<GetUserInfosByIdResult>;

    public record GetUserInfosByIdResult(UserInfoDto Results);

}
