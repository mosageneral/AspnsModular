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


         internal interface IB2BInvoiceItemRepository
    { }

    internal class B2BInvoiceItemRepository : Repository<InvoiceB2B>, IB2BInvoiceItemRepository
    {
        public B2BInvoiceItemRepository(FinancialAppDbContext ctx) : base(ctx)
        { }


    }
}
