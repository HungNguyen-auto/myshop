using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyShop.Model.Models
{
    [Table("OrderDetails")]
    public class OrderDetail
    {
        [Key]
        public int OrderID { set; get; }

        [Key]
        public int ProductID { set; get; }

        [Required]
        public int Quantity { set; get; }

        public virtual Order Order { set; get; }
        public virtual Product Product { set; get; }
    }
}