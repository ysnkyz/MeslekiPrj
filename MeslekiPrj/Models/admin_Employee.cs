using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MeslekiPrj.Models
{
    public partial class admin_Employee
    {
        public admin_Employee()
        {
            this.admin_Login = new HashSet<admin_Login>();
        }
        [Key]
        public int EmpID { get; set; }
        [Display(Name = "Adı")]
        public string FirstName { get; set; }
        [Display(Name = "Soyadı")]
        public string LastName { get; set; }
        [
            Display(Name = "Doğum Tarihi"),
            DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)
        ]
        public Nullable<System.DateTime> DateofBirth { get; set; }
        [Display(Name = "Cinsiyet")]
        public string Gender { get; set; }
        public string Email { get; set; }
        [Display(Name = "Adres")]
        public string Address { get; set; }
        [Display(Name = "Telefon")]
        public string Phone { get; set; }
        public string PicturePath { get; set; }
        public virtual ICollection<admin_Login> admin_Login { get; set; }
    }
}