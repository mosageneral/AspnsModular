namespace Module.Account.DL.Entities.UserEntites
{
    internal class UserRoles : BaseDomain
    {
        public Guid UserId { get; set; }
        public Guid RoleId { get; set; }
    }
}