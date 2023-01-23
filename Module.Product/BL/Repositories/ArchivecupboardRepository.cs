
using BL.Infrastructure;
using Module.Archive.DL.appDBContext;
using Module.Archive.DL.Entities.ArchiveEntities;
using System.Collections.Generic;

namespace BL.Repositories
{
    internal interface IArchivecupboardRepository
    { }

    internal class ArchivecupboardRepository : Repository<Arcivecupboard>, IArchivecupboardRepository
    {
        public ArchivecupboardRepository(ArchiveAppDbContext ctx) : base(ctx)
        { }

       
    }
}
