namespace Module.Account.DL.DTO
{
    internal class AddPermissionToRoleDTO
    {
        public Guid PermissionId { get; set; }
        public Guid RoleId { get; set; }
    }
}