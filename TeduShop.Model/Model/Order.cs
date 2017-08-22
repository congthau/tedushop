using System.ComponentModel.DataAnnotations;
using TeduShop.Model.Abstract;

namespace TeduShop.Model.Model
{
    public class Order : Auditable
    {
        [Key]
        public int ID { set; get; }

        public string CustomerAdress { set; get; }
        [Required]
        public string CustomerMail { set; get; }
        [Required]
        public int CustomerMobile { set; get; }

        public string CustomerMessage { set; get; }
        [Required]
        public string PaymentMethod { set; get; }
        [Required]
        public string PaymentStatus { set; get; }
    }
}