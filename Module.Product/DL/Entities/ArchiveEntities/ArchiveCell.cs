using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.Archive.DL.Entities.ArchiveEntities
{
    internal class ArchiveCell:BaseDomain
    {
        public string CellNameAr { get; set; }
        public string CellNameEn { get; set; }
        public Guid ArcivecupboardId { get; set; }
        public Arcivecupboard Arcivecupboard { get; set; }

    }
}
