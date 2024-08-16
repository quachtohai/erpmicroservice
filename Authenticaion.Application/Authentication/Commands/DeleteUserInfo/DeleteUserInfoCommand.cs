using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authenticaion.Application.Authentication.Commands.DeleteUserInfo
{
    public record DeleteUserInfoCommand(Guid UserInfoId)
    : ICommand<DeleteUserInfoResult>;

    public record DeleteUserInfoResult(bool IsSuccess);

    public class DeleteUserInfoCommandValidator : AbstractValidator<DeleteUserInfoCommand>
    {
        public DeleteUserInfoCommandValidator()
        {
            RuleFor(x => x.UserInfoId).NotEmpty().WithMessage("UserInfoId is required");
        }
    }
}
