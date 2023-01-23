
using BL.Infrastructure;
using Module.Archive.DL.appDBContext;
using Module.Archive.DL.Entities.ArchiveEntities;
using System.Collections.Generic;

namespace BL.Repositories
{
    internal interface IArchiveBuildingRepository
    { }

    internal class ArchiveBuildingRepository : Repository<ArchiveBuilding>, IArchiveBuildingRepository
    {
        public ArchiveBuildingRepository(ArchiveAppDbContext ctx) : base(ctx)
        { }

       
    }
}
