
using BL.Infrastructure;
using Module.Archive.DL.appDBContext;
using Module.Archive.DL.Entities.ArchiveEntities;
using System.Collections.Generic;
using File = Module.Archive.DL.Entities.ArchiveEntities.File;

namespace BL.Repositories
{
    internal interface IFileRepository
    { }

    internal class FileRepository : Repository<File>, IFileRepository
    {
        public FileRepository(ArchiveAppDbContext ctx) : base(ctx)
        { }

       
    }
}
