
using BL.Infrastructure;
using Module.Archive.DL.appDBContext;
using Module.Archive.DL.Entities.ArchiveEntities;
using System.Collections.Generic;

namespace BL.Repositories
{
    internal interface IArchiveRoomRepository
    { }

    internal class ArchiveRoomRepository : Repository<ArchiveRoom>, IArchiveRoomRepository
    {
        public ArchiveRoomRepository(ArchiveAppDbContext ctx) : base(ctx)
        { }

       
    }
}
