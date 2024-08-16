using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authenticaion.Application.Authentication.Commands.DeleteCompanyInfo
{
    public record DeleteCompanyInfoCommand(Guid CompanyInfoId)
    : ICommand<DeleteCompanyInfoResult>;

    public record DeleteCompanyInfoResult(bool IsSuccess);

    public class DeleteCompanyInfoCommandValidator : AbstractValidator<DeleteCompanyInfoCommand>
    {
        public DeleteCompanyInfoCommandValidator()
        {
            RuleFor(x => x.CompanyInfoId).NotEmpty().WithMessage("CompanyInfoId is required");
        }
    }
}
