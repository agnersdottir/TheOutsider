using ObliviousDAL.DomainModel;
using ObliviousDAL.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObliviousDAL.Repository
{
    class ProductRepository : IRepository<Product>
    {
        public Product Add(Product item)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Product item)
        {
            throw new NotImplementedException();
        }
    }
}
