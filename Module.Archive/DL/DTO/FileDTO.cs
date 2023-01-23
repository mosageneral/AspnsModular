using Microsoft.AspNetCore.Http;
using Module.Archive.DL.Entities.ArchiveEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.Archive.DL.DTO
{
    internal class FileDTO
    {
        public string FileName { get; set; }
        public IFormFile FilePath { get; set; }
        public Guid UserId { get; set; }
        public Guid ArchiveCellId { get; set; }
        
    }
}
