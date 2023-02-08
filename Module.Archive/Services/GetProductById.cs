using BL.Infrastructure;
using Shared.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.Product.Services
{
    internal class GetProductById : IGetProductById
    {
        private readonly IUnitOfWork unitOfWork;

        public GetProductById(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        object IGetProductById.GetProductById(Guid ProductId)
        {
            return unitOfWork.ProductRepository.GetById(ProductId);
        }
    }
}
