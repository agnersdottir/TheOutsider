using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObliviousDAL.DomainModel
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Ml { get; set; }
        public string PictureUrl { get; set; }
        public string VideoUrl { get; set; }
        public double Price { get; set; }
        public ICollection<Category> Categories { get; set; }

        //Check out this one, a Product only has one Brand, is this right?
        public Brand Brand { get; set; }

        //Is this enough, what can we add?

    }
}
