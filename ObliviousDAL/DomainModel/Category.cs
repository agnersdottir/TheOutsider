using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObliviousDAL.DomainModel
{
    class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // A Category has many Products and many Brands, right?
        public ICollection<Product> Products { get; set; }
        public ICollection<Brand> Brands { get; set; }

        //Anything else to add ?
        
    }
}
