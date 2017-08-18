using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Model
{
    [Table("SuportOnline")]
    public class SuportOnline
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        public string Department { set; get; }

        [Required]
        public string Skype { set; get; }

        public int? Moble { set; get; }
        public string Yahoo { set; get; }
        public string Facebook { set; get; }
        public bool? Status { set; get; }
    }
}