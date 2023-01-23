using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.Archive.DL.Entities
{
    internal class BaseDomain
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpadtedAt { get; set; }
        public Guid CreatedBy { get; set; }
        public Guid UpdatedBy { get; set; }
        public string? DescribtionEn { get; set; }
        public string? DescribtionAr { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
    }
}
