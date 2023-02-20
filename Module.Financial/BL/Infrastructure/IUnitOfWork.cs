using Module.Financial.BL.Repositories;

namespace BL.Infrastructure
{
    internal interface IUnitOfWork : IDisposable
    {



        B2BInvoiceRepository B2BInvoiceRepository { get; }
        B2BInvoiceItemRepository B2BInvoiceItemRepository { get; }

        B2CInvoiceRepository B2CInvoiceRepository { get; }

        B2CInvoiceItemRepository B2CInvoiceItemRepository { get; }  

        int Save();
      
    }
}
