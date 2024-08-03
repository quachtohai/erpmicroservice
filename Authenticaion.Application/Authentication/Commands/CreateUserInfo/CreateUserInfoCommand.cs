using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authenticaion.Application.Authentication.Commands.CreateUserInfo
{
    public record CreateUserInfoCommand(UserInfoDto UserInfo)
    : ICommand<CreateUserInfoResult>;

    public record CreateUserInfoResult(Guid Id);


    public class CreateUserInfoCommandValidator : AbstractValidator<CreateUserInfoCommand>
    {
        public CreateUserInfoCommandValidator()
        {
            RuleFor(x => x.UserInfo.FirstName).NotEmpty().WithMessage("FirstName is required");
            RuleFor(x => x.UserInfo.LastName).NotEmpty().WithMessage("LastName is required");
            RuleFor(x => x.UserInfo.FullName).NotEmpty().WithMessage("FullName is required");
           
        }
    }

}
