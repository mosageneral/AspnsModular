using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.Archive.DL.Entities.ArchiveEntities
{
    internal class ArchiveFloor:BaseDomain
    {
        public string FloorNameAr { get; set; }
        public string FloorNameEn { get; set; }
        public Guid ArchiveBuildingId { get; set; }
        public ArchiveBuilding ArchiveBuilding { get; set; }
    }
}
