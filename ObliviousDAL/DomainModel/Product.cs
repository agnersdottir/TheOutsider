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
    [Table("Product")]
   public class Product
    {
        [Key]
        [DataMember]
        public int Id { get; set; }
        [Display(Name = "Product")]
        [DataMember]
        public string Name { get; set; }
        [Display(Name = "ml")]
        [DataMember]
        public int Ml { get; set; }

        [Display(Name = "Description")]
        [DataMember]
        public string ProductDescription { get; set; }
        [DataMember]
        public string PictureUrl { get; set; }
        [Display(Name = "See how it´s done")]
        [DataMember]
        public string VideoUrl { get; set; }
        [Display(Name = "Price")]
        [DataMember]
        public double Price { get; set; }

        [Display(Name = "Quantity")]
        [DataMember]
        public int Quantity { get; set; }
        [DataMember]
        public int Rating { get; set; }

        [DataMember]
        public virtual ICollection<Category> Categories { get; set; }

        //Check out this one, a Product only has one Brand, is this right?

        [DataMember]
        //Using List will have one-to-many relation (Product can only have one Brand)
        // research this I am not sure this is the right way.
        public virtual List<Brand> Brands { get; set; }

        //Is this enough?, what can we add?

    }
}
