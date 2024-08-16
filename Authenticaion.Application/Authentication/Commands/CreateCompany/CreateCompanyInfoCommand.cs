using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authenticaion.Application.Authentication.Commands.CreateCompany
{
    public record CreateCompanyInfoCommand(CompanyInfoDto CompanyInfo)
     : ICommand<CreateCompanyInfoResult>;

    public record CreateCompanyInfoResult(Guid Id);


    public class CreateCompanyInfoCommandValidator : AbstractValidator<CreateCompanyInfoCommand>
    {
        public CreateCompanyInfoCommandValidator()
        {
            RuleFor(x => x.CompanyInfo.Name).NotEmpty().WithMessage("Name is required");

        }
    }
}
