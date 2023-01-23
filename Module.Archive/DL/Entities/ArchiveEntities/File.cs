using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.Archive.DL.Entities.ArchiveEntities
{
    internal class File:BaseDomain
    {
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public Guid UserId { get; set; }
        public Guid ArchiveCellId { get; set; }
        public ArchiveCell ArchiveCell { get; set; }
    }
}
