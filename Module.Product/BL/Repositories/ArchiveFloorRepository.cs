
using BL.Infrastructure;
using Module.Archive.DL.appDBContext;
using Module.Archive.DL.Entities.ArchiveEntities;
using System.Collections.Generic;

namespace BL.Repositories
{
    internal interface IArchiveFloorRepository
    { }

    internal class ArchiveFloorRepository : Repository<ArchiveFloor>, IArchiveFloorRepository
    {
        public ArchiveFloorRepository(ArchiveAppDbContext ctx) : base(ctx)
        { }

       
    }
}
