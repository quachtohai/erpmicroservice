using Authentication.Domain.Exceptions;

namespace Authentication.Domain.ValueObjects
{
    public class MenuId
    {
        public Guid Value { get; }
        private MenuId(Guid value) => Value = value;
        public static MenuId Of(Guid value)
        {
            ArgumentNullException.ThrowIfNull(value);
            if (value == Guid.Empty)
            {
                throw new DomainException("DetailInfo cannot be empty.");
            }

            return new MenuId(value);
        }
    }
}
