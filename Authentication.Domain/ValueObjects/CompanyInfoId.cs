using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentication.Domain.ValueObjects
{
    public record CompanyInfoId
    {

        public Guid Value { get; }
        private CompanyInfoId(Guid value) => Value = value;

        public static CompanyInfoId Of(Guid value)
        {
            ArgumentNullException.ThrowIfNull(value);
            if (value == Guid.Empty)
            {
                throw new DomainException("CompanyInfoId cannot be empty.");
            }

            return new CompanyInfoId(value);
        }

    }
}
