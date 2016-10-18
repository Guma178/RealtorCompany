using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace RealtorCompany.Models
{
    public class Flat
    {
        public int FlatID { get; set; }
        public int FlatTypeID { get; set; }
        [StringLength(30, ErrorMessage = "Ошибка. Адрес реализуемой недвижимости не должен занимать больше 30 символов")]
        public string Adress { get; set; }
        public int RoomCount { get; set; }
        public double Squre { get; set; }
        public bool DevidedBath { get; set; }
        public bool Phone { get; set; }
        public decimal Price { get; set; }
        public int SellerID { get; set; }
        //определение связей в базе
        public virtual FlatType FlatType { get; set; }
        public virtual Seller Seller { get; set; }
    }
}