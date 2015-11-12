using ObliviousDAL.DomainModel;
using ObliviousDAL.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObliviousDAL.Repository
{
    class CategoryRepository : IRepository<Category>
    {
        public Category Add(Category item)
        {
            throw new NotImplementedException();
        }

        public Category Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Category> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Category item)
        {
            throw new NotImplementedException();
        }
    }
}
