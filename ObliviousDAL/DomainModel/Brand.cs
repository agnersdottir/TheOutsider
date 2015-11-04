using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObliviousDAL.DomainModel
{
    class Brand
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // A Brand has many Products and Many Categories, right?
        public ICollection<Product> Products { get; set; }
        public ICollection<Category> Categories { get; set; }

        //Do we need more here?
    }
}
