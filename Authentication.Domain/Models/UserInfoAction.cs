namespace Authentication.Domain.Models
{
    public class UserInfoAction : Entity<UserInfoActionId>
    {
        public UserInfoId UserInfoId { get; set; } = default!;
        public ActionInfoId ActionInfoId { get; private set; } = default!;
        public string ActionCode { get; private set; } = default!;
        public string ModuleCode { get; private set; } = default!;
        public string Name { get; private set; } = default!;

        public UserInfoAction(UserInfoId userInfoId, ActionInfoId actionInfoId, 
            string actionCode, string moduleCode, string name)
        {
            Id = UserInfoActionId.Of(Guid.NewGuid());
            UserInfoId = userInfoId;
            ActionInfoId = actionInfoId;
            ActionCode = actionCode;
            ModuleCode = moduleCode;
            Name = name;
        }
    }
}
