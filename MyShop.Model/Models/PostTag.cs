using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyShop.Model.Models
{
    [Table("PostTags")]
    public class PostTag
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PostID { set; get; }

        [Key]
        public string TagID { set; get; }

        [ForeignKey("PostID")]
        public virtual Post Posts { set; get; }

        [ForeignKey("TagID")]
        public virtual Tag Tags { set; get; }
    }
}