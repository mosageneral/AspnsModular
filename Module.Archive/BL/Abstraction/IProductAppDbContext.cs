

using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.Product.BL.Abstraction
{
    internal interface IProductAppDbContext
    {
     
   //   public DbSet<ArchiveCell> ArchiveCells { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
 
}
