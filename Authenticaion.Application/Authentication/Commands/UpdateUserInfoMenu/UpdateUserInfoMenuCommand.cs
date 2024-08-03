using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authenticaion.Application.Authentication.Commands.UpdateUserInfoMenu
{
    public record UpdateUserInfoMenuCommand(UserInfoDto UserInfo)
      : ICommand<UpdateUserInfoMenuResult>;
    public record UpdateUserInfoMenuResult(bool IsSuccess);

    public class UpdateUserInfoMenuCommandValidator : AbstractValidator<UpdateUserInfoMenuCommand>
    {
        public UpdateUserInfoMenuCommandValidator()
        {
            RuleFor(x => x.UserInfo.FirstName).NotEmpty().WithMessage("FirstName is required");
            RuleFor(x => x.UserInfo.LastName).NotEmpty().WithMessage("LastName is required");
            RuleFor(x => x.UserInfo.FullName).NotEmpty().WithMessage("FullName is required");
        }
    }
}
