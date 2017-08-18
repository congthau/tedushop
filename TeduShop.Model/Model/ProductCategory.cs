using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Model.Abstract;

namespace TeduShop.Model.Model
{
    [Table("ProductCategorys")]
    public class ProductCategory: Auditable
    {
        public int ID { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }
        public int? ParentID { set; get; }
        public string Image { set; get; }
        public int? DisplayOrder { set; get; }
        public bool? HomeFlag { set; get; }

        public virtual IEnumerable<Product> Products { set; get; }
    }
}
