using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyShop.Model.Models
{
    [Table("ProductTags")]
    public class ProductTag
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductID { set; get; }

        [Key]
        public string TagID { set; get; }

        public virtual IEnumerable<ProductTag> ProductTags { set; get; }
    }
}