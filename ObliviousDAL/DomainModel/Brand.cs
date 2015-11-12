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
    [Table("Brand")]
   public class Brand
    {
        [Key]
        [DataMember]
        public int Id { get; set; }
        [DataType("Brand")]
        [DataMember]
        public string Name { get; set; }

        // A Brand has many Products and Many Categories, right?

        [DataMember]
        // Reason for List<> Brand has many Products and Products only have one Brand.
        public virtual List<Product> Products { get; set; }

        [DataMember]
        // Reson for List<> Brand has many Categories and Categories only have one Brand.
        public virtual List<Category> Categories { get; set; }

        //Do we need more here?
    }
}
