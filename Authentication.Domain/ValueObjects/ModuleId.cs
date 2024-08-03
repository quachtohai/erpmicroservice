using Authentication.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentication.Domain.ValueObjects
{
    public class ModuleId
    {
        public Guid Value { get; }
        private ModuleId(Guid value) => Value = value;
        public static ModuleId Of(Guid value)
        {
            ArgumentNullException.ThrowIfNull(value);
            if (value == Guid.Empty)
            {
                throw new DomainException("ModuleId cannot be empty.");
            }

            return new ModuleId(value);
        }
    }
}
