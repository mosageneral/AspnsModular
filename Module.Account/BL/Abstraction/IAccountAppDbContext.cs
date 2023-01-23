using Microsoft.EntityFrameworkCore;
using Module.Account.DL.Entities.UserEntites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.Account.BL.Abstraction
{
    internal interface IAccountAppDbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<UserRoles> UserRoles { get; set; }
        public DbSet<PermissionRoles> PermissionRoles { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
 
}
