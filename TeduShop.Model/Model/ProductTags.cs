using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Model
{
    [Table("ProductTags")]
    public class ProductTags
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductID { set; get; }

        [Key]
        public int TagID { set; get; }

        public virtual IEnumerable<Product> Product { set; get; }

        public virtual IEnumerable<Tags> Tags { set; get; }
    }
}