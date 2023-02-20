

using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.Financial.BL.Abstraction
{
    internal interface IFinancialAppDbContext
    {
     
   //   public DbSet<ArchiveCell> ArchiveCells { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
 
}
