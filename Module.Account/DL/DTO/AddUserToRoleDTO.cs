namespace Module.Account.DL.DTO
{
    internal class AddUserToRoleDTO
    {
        public Guid UserId { get; set; }
        public Guid RoleId { get; set; }
    }
}