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


         internal interface IB2CInvoiceItemRepository
    { }

    internal class B2CInvoiceItemRepository : Repository<InvoiceItemB2C>, IB2CInvoiceItemRepository
    {
        public B2CInvoiceItemRepository(FinancialAppDbContext ctx) : base(ctx)
        { }


    }
}
