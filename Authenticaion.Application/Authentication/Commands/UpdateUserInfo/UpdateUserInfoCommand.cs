using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authenticaion.Application.Authentication.Commands.UpdateUserInfo
{
    public record UpdateUserInfoCommand(UserInfoDto UserInfo)
     : ICommand<UpdateUserInfoResult>;
    public record UpdateUserInfoResult(bool IsSuccess);

    public class UpdateUserInfoCommandValidator : AbstractValidator<UpdateUserInfoCommand>
    {
        public UpdateUserInfoCommandValidator()
        {
            RuleFor(x => x.UserInfo.FirstName).NotEmpty().WithMessage("FirstName is required");
            RuleFor(x => x.UserInfo.LastName).NotEmpty().WithMessage("LastName is required");
            RuleFor(x => x.UserInfo.FullName).NotEmpty().WithMessage("FullName is required");
        }
    }
}
