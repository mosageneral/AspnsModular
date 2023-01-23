
using BL.Infrastructure;
using Module.Archive.DL.appDBContext;
using Module.Archive.DL.Entities.ArchiveEntities;
using System.Collections.Generic;

namespace BL.Repositories
{
    internal interface IArchiveCellRepository
    { }

    internal class ArchiveCellRepository : Repository<ArchiveCell>, IArchiveCellRepository
    {
        public ArchiveCellRepository(ArchiveAppDbContext ctx) : base(ctx)
        { }

       
    }
}
