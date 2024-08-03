using Authentication.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentication.Domain.ValueObjects
{
    public record UserInfoDetailId
    {
        public Guid Value { get; }
        private UserInfoDetailId(Guid value) => Value = value;
        public static UserInfoDetailId Of(Guid value)
        {
            ArgumentNullException.ThrowIfNull(value);
            if (value == Guid.Empty)
            {
                throw new DomainException("UserInfoDetailId cannot be empty.");
            }

            return new UserInfoDetailId(value);
        }
    }
}
