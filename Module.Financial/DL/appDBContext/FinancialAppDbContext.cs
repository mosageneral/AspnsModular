using Microsoft.EntityFrameworkCore;
using Module.Financial.BL.Abstraction;
using Module.Financial.DL.Entities.FinancialEntities;
using Shared.Infrastructure.Persistence;

namespace Module.Financial.DL.appDBContext
{
    internal class FinancialAppDbContext : ModuleDbContext, IFinancialAppDbContext
    {
        protected override string Schema => "Financial";



        public FinancialAppDbContext(DbContextOptions<FinancialAppDbContext> options) : base(options)
        {
           
        }


        public DbSet<InvoiceB2B> InvoiceB2Bs { get; set; }

        public DbSet<InvoiceB2C> InvoiceB2Cs { get; set; }

        public DbSet<InvoiceItemB2B> InvoiceItemB2Bs { get; set; }

        public DbSet<InvoiceItemB2C> InvoiceItemB2Cs { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            base.OnModelCreating(modelBuilder);
        }
    }
}
