using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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

        public virtual IEnumerable<Order> Order { set; get; }

        public virtual IEnumerable<ProductCategory> ProductCategory { set; get; }
    }
}