using Authentication.Domain.Exceptions;

namespace Authentication.Domain.ValueObjects
{
    public class FormId
    {
        public Guid Value { get; }
        private FormId(Guid value) => Value = value;
        public static FormId Of(Guid value)
        {
            ArgumentNullException.ThrowIfNull(value);
            if (value == Guid.Empty)
            {
                throw new DomainException("DetailInfo cannot be empty.");
            }

            return new FormId(value);
        }
    }
}
