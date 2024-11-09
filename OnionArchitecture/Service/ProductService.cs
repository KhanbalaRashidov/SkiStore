using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    internal class ProductService : IProductService
    {
        public Task GetAll()
        {
            throw new NotImplementedException();
        }

        public Task GetById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
