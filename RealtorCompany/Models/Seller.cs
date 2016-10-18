using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace RealtorCompany.Models
{
    public class Seller
    {
        public int SellerID { get; set; }
        [StringLength(40, ErrorMessage = "Ошибка. ФИО продавца не должено занимать больше 40 символов")]
        public string FLF { get; set; }
        public char Sex { get; set; }
        public DateTime BDay { get; set; }
        [StringLength(30, ErrorMessage = "Ошибка. Адрес продавца не должен занимать больше 30 символов")]
        public string Adress { get; set; }
        [StringLength(12, ErrorMessage = "Ошибка. Паспортные данные продавца не должены занимать больше 12 символов")]
        public string Pasport { get; set; }
        public int Phone { get; set; }
        [StringLength(60, ErrorMessage = "Ошибка. Информация о продавце не должена занимать больше 60 символов")]
        public string Information { get; set; }
        //определение связей в базе
        public ICollection<Flat> Flat { get; set; }
        public ICollection<Contract> Contract { get; set; }
    }
}