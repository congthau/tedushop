using System;
using System.Xml.Linq;

namespace TeduShop.Model.Abstract
{
    public abstract class Auditable : IAuditable
    {
        public  string CreatedBy { get; set; }
        public  DateTime? CreatedDate { get; set; }
        public  string MetaDescription { get; set; }
        public  string MetaKeyword { get; set; }
        public  bool Status { get; set; }
        public  string UpdatedBy { get; set; }
        public  DateTime? UpdatedDate { get; set; }
        public string Image { set; get; }
        public XElement MoreImage { set; get; }
    }
}