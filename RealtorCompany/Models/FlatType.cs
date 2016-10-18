using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace RealtorCompany.Models
{
    public class FlatType
    {
        public int FlatTypeID { get; set; }
        [StringLength(25, ErrorMessage = "Ошибка. Название типа недвижимости не должено занимать больше 25 символов")]
        public string Name { get; set; }
        [StringLength(60, ErrorMessage = "Ошибка. Информация о типе недвижимости не должена занимать больше 60 символов")]
        public string Information { get; set; }
        //определение связей в базе
        public ICollection<Flat> Flat { get; set; }
        public ICollection<WantedFlat> WantedFlat { get; set; }
    }
}