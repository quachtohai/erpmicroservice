using Authentication.Domain.Exceptions;

namespace Authentication.Domain.ValueObjects
{
    public class MasterInfoId
    {
        public Guid Value { get; }
        private MasterInfoId(Guid value) => Value = value;
        public static MasterInfoId Of(Guid value)
        {
            ArgumentNullException.ThrowIfNull(value);
            if (value == Guid.Empty)
            {
                throw new DomainException("DetailInfo cannot be empty.");
            }

            return new MasterInfoId(value);
        }
    }
}
