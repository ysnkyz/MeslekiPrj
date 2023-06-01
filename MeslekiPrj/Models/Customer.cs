using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MeslekiPrj.Models
{
    public partial class Customer
    {
        public Customer()
        {
            this.Orders = new HashSet<Order>();
            this.RecentlyViews = new HashSet<RecentlyView>();
            this.Reviews = new HashSet<Review>();
            this.Wishlists = new HashSet<Wishlist>();
        }
        [Key]
        public int CustomerID { get; set; }
        [Display(Name = "Adı")]
        public string First_Name { get; set; }
        [Display(Name = "Soyadı")]
        public string Last_Name { get; set; }
        [Display(Name = "Kullanıcı Adı")]
        public string UserName { get; set; }
        [Display(Name = "Şifre")]
        public string Password { get; set; }
        public string Gender { get; set; }
        [Display(Name = "Doğum Tarihi")]
        public Nullable<System.DateTime> DateofBirth { get; set; }
        [Display(Name = "Ülke")]
        public string Country { get; set; }
        [Display(Name = "Şehir")]
        public string City { get; set; }
        [Display(Name = "Posta Kodu")]
        public string PostalCode { get; set; }
        public string Email { get; set; }
        [Display(Name = "Telefon")]
        public string Phone { get; set; }
        [Display(Name = "Adres")]
        public string Address { get; set; }
        [Display(Name = "Picture")]
        public string PicturePath { get; set; }
        public string status { get; set; }
        public Nullable<System.DateTime> LastLogin { get; set; }
        public Nullable<System.DateTime> Created { get; set; }
        [Display(Name = "Notlar")]
        public string Notes { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<RecentlyView> RecentlyViews { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
        public virtual ICollection<Wishlist> Wishlists { get; set; }
    }
}