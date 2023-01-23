using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.Archive.DL.Entities.ArchiveEntities
{
    internal class Arcivecupboard:BaseDomain
    {
        public string cupboardNameAr { get; set; }
        public string cupboardNameEn { get; set; }
        public Guid ArchiveRoomId { get; set; }
        public ArchiveRoom ArchiveRoom { get; set; }
    }
}
