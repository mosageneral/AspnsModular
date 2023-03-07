using BL.Repositories;
using Module.Account.BL.Repositories;

namespace BL.Infrastructure
{
    internal interface IUnitOfWork : IDisposable
    {
        UserRepository UserRepository { get; }
        RoleRepository RoleRepository { get; }
        UserRolesRepository UserRolesRepository { get; }
        PermissionRepository PermissionRepository { get; }
        PermissionRoleRepository PermissionRoleRepository { get; }
        CountryRepository CountryRepository { get; }
        RegionRepository RegionRepository { get; }
        CityRepository CityRepository { get; }
        VendorRepository VendorRepository { get; }
        VerfiyCodeRepository VerfiyCodeRepository { get; }

        int Save();
    }
}