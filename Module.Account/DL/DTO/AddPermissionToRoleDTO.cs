using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.Account.DL.DTO
{
    internal class AddPermissionToRoleDTO
    {
        public Guid PermissionId { get; set; }
        public Guid RoleId { get; set; }
    }
}
