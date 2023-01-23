using BL.Security;
using Module.Account.DL.Entities.UserEntites;
using Shared.Models.Constant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.Account.DL.DataSeeds
{
    internal static class UserSeeds
    {
        public static User AdminUser = new User { Id = Guid.NewGuid(), UserName = "Admin", Password = EncryptANDDecrypt.EncryptText("Admin") };
        public static User BasicUSer = new User { Id = Guid.NewGuid(), UserName = "Basic", Password = EncryptANDDecrypt.EncryptText("Basic") };
    }

    internal static class RoleSeeds
    {
        public static Role AdminRole = new Role { Id = Guid.NewGuid(), NameAr = "صلاحية المدير", NameEn = "AdminRole" };
        public static Role BasicRole = new Role { Id = Guid.NewGuid(), NameAr = "صلاحية مستخدم", NameEn = "BasicRole" };
    }
    internal static class PermissionSeeds
    {
      
        public static Permission Archive = new Permission { Id = Guid.NewGuid(), NameAr = "صلاحية استخدام الارشيف", NameEn = PermissionsConst.Archive };
        public static Permission Admin = new Permission { Id = Guid.NewGuid(), NameAr = "صلاحية المدير", NameEn = PermissionsConst.Admin };
    }
    internal static class UserRolesSeeds
    {
        public static UserRoles UserAdmin_RoleAdmin = new UserRoles { Id = Guid.NewGuid(), RoleId = RoleSeeds.AdminRole.Id, UserId =UserSeeds.AdminUser.Id};
        public static UserRoles UserAdmin_RoleBasic = new UserRoles { Id = Guid.NewGuid(), RoleId = RoleSeeds.BasicRole.Id, UserId =UserSeeds.AdminUser.Id};
        public static UserRoles UserBasic_RoleBasic = new UserRoles { Id = Guid.NewGuid(), RoleId = RoleSeeds.BasicRole.Id, UserId =UserSeeds.BasicUSer.Id};
    }
    internal static class RolesPermissionSeeds
    {
        public static PermissionRoles RoleAdmin_PermissionAddUser = new PermissionRoles { Id = Guid.NewGuid(),PermissionId=PermissionSeeds.Admin.Id,RoleId=RoleSeeds.AdminRole.Id };
        public static PermissionRoles RoleAdmin_PermissionGetAllUser= new PermissionRoles { Id = Guid.NewGuid(),PermissionId=PermissionSeeds.Archive.Id,RoleId=RoleSeeds.AdminRole.Id };
        public static PermissionRoles RoleBasic_PermissionGetAllUser = new PermissionRoles { Id = Guid.NewGuid(),PermissionId=PermissionSeeds.Archive.Id,RoleId=RoleSeeds.BasicRole.Id };
    }
}
