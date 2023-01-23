using BL.Repositories;
using Module.Account.DL.appDBContext;

namespace BL.Infrastructure
{
    internal class UnitOfWork : IUnitOfWork
    {
        private AccountAppDbContext _ctx;
        public UnitOfWork(AccountAppDbContext ctx)
        {
            _ctx = ctx;
            _ctx.ChangeTracker.LazyLoadingEnabled = true;
        }


        public UserRepository UserRepository => new UserRepository(_ctx);
        public RoleRepository RoleRepository => new RoleRepository(_ctx);
        public UserRolesRepository UserRolesRepository => new UserRolesRepository(_ctx);
        public PermissionRoleRepository PermissionRoleRepository => new PermissionRoleRepository(_ctx);
        public PermissionRepository PermissionRepository => new PermissionRepository(_ctx);
      

        public void Dispose()
        {
            _ctx.Dispose();
        }



        public int Save()
        {
            return _ctx.SaveChanges();
        }
    }
}
