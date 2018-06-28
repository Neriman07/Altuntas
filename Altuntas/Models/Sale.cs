using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Altuntas.Models
{
    public class Sale
    {
      public int Id { get; set; }
    [Display(Name = "Satıcı")]
    public int SellerId { get; set; }
    [ForeignKey("SellerId")]
     [Display(Name ="Satıcı")]
    public Seller Seller { get; set; }
    [Display(Name = "Model")]
    public string Model { get; set; }
    [Display(Name = "Alıcı")]
    public int BuyerId { get; set; }
    [ForeignKey("BuyerId")]
      public Buyer Buyer { get; set; }
    [Display(Name = "Adres")]
    [StringLength(4000)]
    public string Address { get; set; }
    [Display(Name = "Genişlik")]
    public double? Width { get; set; }
    [Display(Name = "Yükseklik")]
    public double? Height{ get; set; }
    [Display(Name = "Uzunluk")]
    public double? Length{ get; set; }
    [Display(Name = "Aldığı Kalıplar")]
    [StringLength(4000)]
    public string  RecievedtForms { get; set; }
    [Display(Name = "Garanti Bitiş Tarihi")]
    public DateTime? WarantyEndDate { get; set; }
    [Display(Name = "Fatura Bedeli ")]
    public decimal? InvoicaPrice { get; set; }
    [Display(Name = "Bizim Satış Fiyatı")]
    public decimal  OurSalePrice{ get; set; }
    [Display(Name = "Komisyon")]
    public decimal? Commission { get; set; }
    [Display(Name = "Ekstra Kalıp Fiyatı")]
    [StringLength(4000)]
    public string  ExtraFormPrice { get; set; }
    [Display(Name = "Açıklama")]
    public string  Description { get; set; }
    [Display(Name = "Oluşturma Tarihi")]
    public DateTime CreateDate { get; set; }
    [Display(Name = "Oluşturan kullanıcı")]
    public string CreateBy{ get; set; }
    [Display(Name = "Güncelleme tarihi ")]
    public DateTime UpdateDate{ get; set; }
    [Display(Name = "Güncelleyen kullanıcı")]
    public string UpdateBy { get; set; }



  }
}
