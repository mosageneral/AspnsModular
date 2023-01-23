
using BL.Infrastructure;
using Module.Archive.DL.appDBContext;
using Module.Archive.DL.Entities.ArchiveEntities;
using System.Collections.Generic;

namespace BL.Repositories
{
    internal interface IFileTransactionHistoryRepository
    { }

    internal class FileTransactionHistoryRepository : Repository<FileTransactionHistory>, IFileTransactionHistoryRepository
    {
        public FileTransactionHistoryRepository(ArchiveAppDbContext ctx) : base(ctx)
        { }

       
    }
}
