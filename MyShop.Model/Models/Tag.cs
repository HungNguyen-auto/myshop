using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyShop.Model.Models
{
    [Table("Tags")]
    public class Tag
    {
        [Key]
        public int ID { set; get; }

        public string Name { set; get; }
        public string Type { set; get; }
        public virtual IEnumerable<PostTag> PostTags { set; get; }
    }
}