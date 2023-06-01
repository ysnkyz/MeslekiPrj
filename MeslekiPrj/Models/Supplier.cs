using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MeslekiPrj.Models
{
    public partial class Supplier
    {
        public Supplier()
        {
            this.Products = new HashSet<Product>();
        }
        [Key]
        public int SupplierID { get; set; }
        [Required, Display(Name = "Firma Adı")]
        public string CompanyName { get; set; }
        [Required, Display(Name = "İletişim Adı")]
        public string ContactName { get; set; }
        [Required, Display(Name = "İletişim Başlığı")]
        public string ContactTitle { get; set; }
        [Required, Display(Name = "Adres")]
        public string Address { get; set; }
        [Required, Display(Name = "Telefon")]
        public string Phone { get; set; }
        [Required]
        public string Email { get; set; }
        [Required, Display(Name = "Şehir")]
        public string City { get; set; }
        [Required, Display(Name = "Ülke")]
        public string Country { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}