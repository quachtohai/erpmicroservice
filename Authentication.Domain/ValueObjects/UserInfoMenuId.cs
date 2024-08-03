using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentication.Domain.ValueObjects
{
    public record UserInfoMenuId
    {
        public Guid Value { get; }
        private UserInfoMenuId(Guid value) => Value = value;

        public static UserInfoMenuId Of(Guid value)
        {
            ArgumentNullException.ThrowIfNull(value);
            if (value == Guid.Empty)
            {
                throw new DomainException("UserInfoMenuId cannot be empty.");
            }

            return new UserInfoMenuId(value);
        }
    }
}
