using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MeslekiPrj.Models
{
    public class EmployeeVM
    {
        public int EmpID { get; set; }
        [Display(Name = "Adı")]
        [Required, RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Name contains only Alphabets")]
        public string FirstName { get; set; }
        [Display(Name = "Soyadı")]
        [Required, RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Name contains only Alphabets")]
        public string LastName { get; set; }
        [
            Required,
            Display(Name = "Doğum Tarihi"),
            DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true),
            DataType(DataType.Date)
        ]
        public Nullable<System.DateTime> DateofBirth { get; set; }
        [Required,Display(Name = "Cinsiyet")]
        public string Gender { get; set; }
        [Required, DataType(DataType.EmailAddress, ErrorMessage = "Please enter correct email address")]
        public string Email { get; set; }
        [Display(Name = "Adres")]
        public string Address { get; set; }
        [Required, DataType(DataType.PhoneNumber, ErrorMessage = "Mobile number contains only Numbers"),
            Display(Name = "Telefon")]
        public string Phone { get; set; }
        [Display(Name = "Görsel")]
        public string PicturePath { get; set; }
        [Display(Name = "Görsel")]
        public HttpPostedFileBase Picture { get; set; }

    }
}