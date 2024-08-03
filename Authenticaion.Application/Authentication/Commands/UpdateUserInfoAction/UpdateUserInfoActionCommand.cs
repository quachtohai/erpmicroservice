using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authenticaion.Application.Authentication.Commands.UpdateUserInfoAction
{
    public record UpdateUserInfoActionCommand(UserInfoDto UserInfo)
      : ICommand<UpdateUserInfoActionResult>;
    public record UpdateUserInfoActionResult(bool IsSuccess);

    public class UpdateUserInfoActionCommandValidator : AbstractValidator<UpdateUserInfoActionCommand>
    {
        public UpdateUserInfoActionCommandValidator()
        {
            RuleFor(x => x.UserInfo.FirstName).NotEmpty().WithMessage("FirstName is required");
            RuleFor(x => x.UserInfo.LastName).NotEmpty().WithMessage("LastName is required");
            RuleFor(x => x.UserInfo.FullName).NotEmpty().WithMessage("FullName is required");
        }
    }
}
