using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Model
{
    public class OrderDetail
    {
        [Key]
        public int ID { set; get; }

        [Key]
        public int ProductID { set; get; }

        [Required]
        public int? Quantity { set; get; }

        [ForeignKey("OrderID")]
        public virtual Order Order { set; get; }
        [ForeignKey("ProductID")]
        public virtual ProductCategory ProductCategory { set; get; }
    }
}