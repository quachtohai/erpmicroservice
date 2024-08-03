using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentication.Domain.ValueObjects
{
    public record UserInfoActionId
    {
        public Guid Value { get; }
        private UserInfoActionId(Guid value) => Value = value;

        public static UserInfoActionId Of(Guid value)
        {
            ArgumentNullException.ThrowIfNull(value);
            if (value == Guid.Empty)
            {
                throw new DomainException("UserInfoActionId cannot be empty.");
            }

            return new UserInfoActionId(value);
        }
    }
}
