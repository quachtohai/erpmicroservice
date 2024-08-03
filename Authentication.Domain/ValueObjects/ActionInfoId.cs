namespace Authentication.Domain.ValueObjects
{
    public record ActionInfoId
    {
        public Guid Value { get; }
        private ActionInfoId(Guid value) => Value = value;
        public static ActionInfoId Of(Guid value)
        {
            ArgumentNullException.ThrowIfNull(value);
            if (value == Guid.Empty)
            {
                throw new DomainException("ActionsId cannot be empty.");
            }

            return new ActionInfoId(value);
        }
    }
}
