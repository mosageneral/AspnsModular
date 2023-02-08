using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models.Interfaces
{
    public interface IGetProductById
    {
        public object GetProductById(Guid ProductId); 
    }
}
