using BL.Repositories;

using System;

namespace BL.Infrastructure
{
    internal interface IUnitOfWork : IDisposable
    {

        UserRepository UserRepository { get; }
        RoleRepository RoleRepository { get; }
        UserRolesRepository UserRolesRepository { get; }
        PermissionRepository PermissionRepository { get; }
        PermissionRoleRepository PermissionRoleRepository { get; }


        int Save();
      
    }
}
