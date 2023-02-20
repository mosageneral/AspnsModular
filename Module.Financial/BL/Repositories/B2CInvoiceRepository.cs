using BL.Infrastructure;
using Module.Financial.DL.appDBContext;
using Module.Financial.DL.Entities.FinancialEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Module.Financial.BL.Repositories
{


         internal interface IB2CInvoiceRepository
    { }

    internal class B2CInvoiceRepository : Repository<InvoiceB2C>, IB2CInvoiceRepository
    {
        public B2CInvoiceRepository(FinancialAppDbContext ctx) : base(ctx)
        { }


    }
}
