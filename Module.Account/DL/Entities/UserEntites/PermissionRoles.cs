using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.Account.DL.Entities.UserEntites
{
    internal class PermissionRoles:BaseDomain
    {
        public Guid PermissionId { get; set; }
        public Guid RoleId { get; set; }

    }
}
