using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MeslekiPrj.Models
{
    public class ProductVM
    {
        public int ProductID { get; set; }
        [Required, Display(Name = "Ürün Adı")]
        public string Name { get; set; }
        [Required, Display(Name = "Tedarikçi")]
        public int SupplierID { get; set; }
        [Required, Display(Name = "Kategori")]
        public int CategoryID { get; set; }
        [Display(Name = "Alt Kategori")]
        public Nullable<int> SubCategoryID { get; set; }
        [Display(Name = "Birim fiyat")]
        public decimal UnitPrice { get; set; }
        [Required, Display(Name = "Önceki fiyat")]
        public Nullable<decimal> OldPrice { get; set; }
        public Nullable<decimal> Discount { get; set; }
        [Display(Name = "Stok")]
        public Nullable<int> UnitInStock { get; set; }
        [Display(Name = "Available?")]
        public Nullable<bool> ProductAvailable { get; set; }
        [Display(Name = "Açıklama")]
        public string ShortDescription { get; set; }
        [Display(Name = "Picture")]
        public string PicturePath { get; set; }
        [Display(Name = "Görsel")]
        public HttpPostedFileBase Picture { get; set; }
        public string Note { get; set; }
    }
}