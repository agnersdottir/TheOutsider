using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ObliviousDAL.DomainModel
{
    [DataContract(IsReference = true)]
    [Table("Category")]
   public class Category
    {
        public Category()
        {
            this.Products = new HashSet<Product>();
        }
        [Key]
        [DataMember]
        public int Id { get; set; }
        [DataType("Category")]
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        //Using Icollection with HashSet for many-to-many relation
        public virtual ICollection<Product> Products { get; set; }

        [DataMember]
        // Using List<> to apply one-to-many relation
        // Example: Categories can have many Brands and Brands can only have one category
        public virtual List<Brand> Brands { get; set; }

        //Anything else to add ?
        
    }
}
