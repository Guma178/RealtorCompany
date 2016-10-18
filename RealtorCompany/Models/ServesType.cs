using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace RealtorCompany.Models
{
    public class ServesType
    {
        public int ServesTypeID { get; set; }
        [StringLength(25, ErrorMessage = "Ошибка. Название услуги не должено занимать больше 25 символов")]
        public string Name { get; set; }
        [StringLength(25, ErrorMessage = "Ошибка. Описание услуги не должено занимать больше 60 символов")]
        public string Discription { get; set; }
        public decimal Money { get; set; }
        //Определение связей в БД
        public ICollection<ServesType> ServerTypes { get; set; }
    }
}