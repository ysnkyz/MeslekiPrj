using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MeslekiPrj.Models
{
    public class CustomerVM
    {
        public int CustomerID { get; set; }
        [Display(Name = "Adı")]
        [Required, RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "UYGUN HARF GİRİNİZ")]
        public string First_Name { get; set; }
        [Display(Name = "Soyadı")]
        [Required, RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "UYGUN HARF GİRİNİZ")]
        public string Last_Name { get; set; }
        [Required, Display(Name = "Kullanıcı adı")]
        public string UserName { get; set; }
        [Required, Display(Name = "Şifre")]
        public string Password { get; set; }
        [Required, Display(Name = "Cinsiyet")]
        public string Gender { get; set; }
        [
            Required,
            Display(Name = "Doğum Tarihi"),
            DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true),
            DataType(DataType.Date)
        ]
        public Nullable<System.DateTime> DateofBirth { get; set; }
        [Required, Display(Name = "Ülke")]
        public string Country { get; set; }
        [Required, Display(Name = "Şehir")]
        public string City { get; set; }
        [Display(Name = "Posta Kodu")]
        public string PostalCode { get; set; }
        [Required, DataType(DataType.EmailAddress, ErrorMessage = "Lütfen Doğru Email Girdiğinizden Emin Olun!")]
        public string Email { get; set; }
        [Required,DataType(DataType.PhoneNumber, ErrorMessage = "Yalnızca Cep-Telefonu Numaraları İçermeli!")
         ,Display(Name = "Telefon")]
        public string Phone { get; set; }
        [Required,Display(Name = "Adres")]
        public string Address { get; set; }
        [Display(Name = "Picture")]
        public string PicturePath { get; set; }
        [Required, Display(Name = "Görsel")]
        public HttpPostedFileBase Picture { get; set; }
        public string status { get; set; }
        public Nullable<System.DateTime> LastLogin { get; set; }
        public Nullable<System.DateTime> Created { get; set; }
        public string Notes { get; set; }


    }
}