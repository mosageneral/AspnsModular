

using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.OrderManagment.BL.Abstraction
{
    internal interface IOrderManagmentAppDbContext
    {
     
   //   public DbSet<ArchiveCell> ArchiveCells { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
 
}
