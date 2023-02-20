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
    
    internal interface IB2BInvoiceRepository
    { }

    internal class B2BInvoiceRepository : Repository<InvoiceB2B>, IB2BInvoiceRepository
    {
        public B2BInvoiceRepository(FinancialAppDbContext ctx) : base(ctx)
        { }


    }
}
