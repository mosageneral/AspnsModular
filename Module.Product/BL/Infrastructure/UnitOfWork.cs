
using BL.Repositories;
using Module.Archive.BL.Abstraction;
using Module.Archive.DL.appDBContext;

namespace BL.Infrastructure
{
    internal class UnitOfWork : IUnitOfWork
    {
        private ArchiveAppDbContext _ctx;
        public UnitOfWork(ArchiveAppDbContext ctx)
        {
            _ctx = ctx;
            _ctx.ChangeTracker.LazyLoadingEnabled = true;
        }

        public ArchiveBuildingRepository ArchiveBuildingRepository =>  new ArchiveBuildingRepository(_ctx);

        public ArchiveFloorRepository ArchiveFloorRepository => new ArchiveFloorRepository(_ctx);

        public ArchiveRoomRepository ArchiveRoomRepository => new ArchiveRoomRepository(_ctx);

        public ArchivecupboardRepository ArchivecupboardRepository => new ArchivecupboardRepository(_ctx);

        public ArchiveCellRepository ArchiveCellRepository => new ArchiveCellRepository(_ctx);
        public FileRepository FileRepository => new FileRepository(_ctx);
        public FileTransactionHistoryRepository FileTransactionHistoryRepository => new FileTransactionHistoryRepository(_ctx);





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
