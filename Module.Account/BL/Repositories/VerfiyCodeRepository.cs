using BL.Infrastructure;
using Module.Account.DL.appDBContext;
using Module.Account.DL.Entities.UserEntities;

namespace Module.Account.BL.Repositories
{
    public interface IVerfiyCodeRepository
    { }

    internal class VerfiyCodeRepository : Repository<VerfiyCode>, IVerfiyCodeRepository
    {
        public VerfiyCodeRepository(AccountAppDbContext ctx) : base(ctx)
        { }
    }
}