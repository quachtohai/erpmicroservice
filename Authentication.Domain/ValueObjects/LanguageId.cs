using Authentication.Domain.Exceptions;

namespace Authentication.Domain.ValueObjects
{
    public class LanguageId
    {
        public Guid Value { get; }
        private LanguageId(Guid value) => Value = value;
        public static LanguageId Of(Guid value)
        {
            ArgumentNullException.ThrowIfNull(value);
            if (value == Guid.Empty)
            {
                throw new DomainException("DetailInfo cannot be empty.");
            }

            return new LanguageId(value);
        }
    }
}
