using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace RealtorCompany.Models
{
    public class Buyer
    {
        public int BuyerID { get; set; }
        [StringLength(40, ErrorMessage = "Ошибка. ФИО покупателя не должено занимать больше 40 символов")]
        public string FLF { get; set; }
        public char Sex { get; set; }
        public DateTime BDay { get; set; }
        [StringLength(30, ErrorMessage = "Ошибка. Адрес покупателя не должен занимать больше 30 символов")]
        public string Adress { get; set; }
        [StringLength(12, ErrorMessage = "Ошибка. Паспортные данные покупателя не должены занимать больше 12 символов")]
        public string Pasport { get; set; }
        //связи с таблицами
        public ICollection<Contract> Contract { get; set; }
        public ICollection<WantedFlat> WantedFlat { get; set; }
    }
}