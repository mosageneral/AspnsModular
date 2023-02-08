using Microsoft.EntityFrameworkCore;
using Module.OrderManagment.BL.Abstraction;
using Module.OrderManagment.DL.Entities.OrderManagmentEntities;
using Shared.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.OrderManagment.DL.appDBContext
{
    internal class OrderManagmentAppDbContext : ModuleDbContext,IOrderManagmentAppDbContext
    {
        protected override string Schema => "OrderManagment";



        public OrderManagmentAppDbContext(DbContextOptions<OrderManagmentAppDbContext> options) : base(options)
        {
        }


        public DbSet<Order> Orders { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            base.OnModelCreating(modelBuilder);
        }
    }
}
