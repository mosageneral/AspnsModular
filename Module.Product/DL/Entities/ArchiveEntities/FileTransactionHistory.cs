using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.Archive.DL.Entities.ArchiveEntities
{
    internal class FileTransactionHistory : BaseDomain
    {
        public Guid FileId { get; set; }
        public Guid UserId { get; set; }
        public string TransactionAr { get; set; }
        public string TransactionEn { get; set; }
    }
}
