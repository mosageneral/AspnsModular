using Microsoft.EntityFrameworkCore;

using Module.Archive.BL.Abstraction;
using Module.Archive.DL.Entities.ArchiveEntities;
using Shared.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.Archive.DL.appDBContext
{
    internal class ArchiveAppDbContext : ModuleDbContext,IArchiveAppDbContext
    {
        protected override string Schema => "Archive";

       

        public ArchiveAppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<ArchiveBuilding> ArchiveBuildings { get; set; }
        public DbSet<ArchiveFloor> ArchiveFloors { get; set; }
        public DbSet<ArchiveRoom> ArchiveRooms { get; set; }
        public DbSet<Arcivecupboard> Arcivecupboards { get; set; }
        public DbSet<ArchiveCell> ArchiveCells { get; set; }
        public DbSet<Entities.ArchiveEntities.File> Files { get; set; }
        public DbSet<Entities.ArchiveEntities.FileTransactionHistory> FileTransactionHistories { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            base.OnModelCreating(modelBuilder);
        }
    }
}
