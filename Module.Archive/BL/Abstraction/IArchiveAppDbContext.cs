

using Microsoft.EntityFrameworkCore;
using Module.Archive.DL.Entities.ArchiveEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.Archive.BL.Abstraction
{
    internal interface IArchiveAppDbContext
    {
      public DbSet<ArchiveBuilding> ArchiveBuildings  { get; set; }
      public DbSet<ArchiveFloor> ArchiveFloors { get; set; }
      public DbSet<ArchiveRoom> ArchiveRooms { get; set; }
      public DbSet<Arcivecupboard> Arcivecupboards { get; set; }
      public DbSet<ArchiveCell> ArchiveCells { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
 
}
