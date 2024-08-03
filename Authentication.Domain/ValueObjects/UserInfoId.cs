using Authentication.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentication.Domain.ValueObjects
{
    public record UserInfoId
    {
       
        public Guid Value { get; }
        private UserInfoId(Guid value) => Value = value;

        public static UserInfoId Of(Guid value)
        {
            ArgumentNullException.ThrowIfNull(value);
            if (value == Guid.Empty)
            {
                throw new DomainException("UserInfoId cannot be empty.");
            }

            return new UserInfoId(value);
        }

    }
}
