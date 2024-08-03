using Authentication.Domain.Exceptions;

namespace Authentication.Domain.ValueObjects
{
    public class DetailInfoId
    {
        public Guid Value { get; }
        private DetailInfoId(Guid value) => Value = value;
        public static DetailInfoId Of(Guid value)
        {
            ArgumentNullException.ThrowIfNull(value);
            if (value == Guid.Empty)
            {
                throw new DomainException("DetailInfo cannot be empty.");
            }

            return new DetailInfoId(value);
        }
    }
}
