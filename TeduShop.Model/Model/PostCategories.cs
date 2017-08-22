using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TeduShop.Model.Abstract;

namespace TeduShop.Model.Model
{
    public class PostCategories : Auditable
    {
        [Key]
        public int ID { set; get; }
        [Required]
        public string Name { set; get; }
        [Required]
        public string Alas { set; get; }
        public int? ParentID { set; get; }
        public int? DisplayOder { set; get; }

        public virtual IEnumerable<Post> Post { set; get; }
    }
}