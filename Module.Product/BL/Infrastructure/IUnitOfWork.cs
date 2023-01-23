

using BL.Repositories;
using Module.Archive.DL.Entities.ArchiveEntities;
using System;

namespace BL.Infrastructure
{
    internal interface IUnitOfWork : IDisposable
    {

        ArchiveBuildingRepository ArchiveBuildingRepository { get; }
        ArchiveFloorRepository ArchiveFloorRepository { get; }
        ArchiveRoomRepository ArchiveRoomRepository { get; }
        ArchivecupboardRepository ArchivecupboardRepository { get; }
        ArchiveCellRepository ArchiveCellRepository { get; }
        FileRepository FileRepository { get; }
        FileTransactionHistoryRepository FileTransactionHistoryRepository { get; }



        int Save();
      
    }
}
