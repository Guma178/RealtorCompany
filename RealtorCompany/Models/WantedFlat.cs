using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace RealtorCompany.Models
{
    public class WantedFlat
    {
        public int WantedFlatID { get; set; }
        [StringLength(30, ErrorMessage = "Ошибка. Адрес искомой пкупателем квартиры не должен занимать больше 30 символов")]
        public string Adress { get; set; }
        public int FlatTypeID { get; set; }
        public int RoomCount { get; set; }
        public double Squre { get; set; }
        public bool DevidedBath { get; set; }
        public bool Phone { get; set; }
        public decimal Price { get; set; }
        [StringLength(60, ErrorMessage = "Ошибка. Информация о искомой пкупателем квартире не должена занимать больше 60 символов")]
        public string Information { get; set; }
        public int BuyerID { get; set; }
        //определение связей в базе
        public virtual FlatType FlatType { get; set; }
        public virtual Buyer Buyer { get; set; }
    }
}