using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyShop.Model.Models
{
    [Table("VisitorStatistics")]
    public class VisitorStatistic
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        public DateTime VisitedDate { set; get; }

        [Required]
        public string IPAddress { set; get; }
    }
}