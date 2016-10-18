using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace RealtorCompany.Models
{
    public class Contract
    {
        public int ContractID { get; set; }
        public DateTime Date { get; set; }
        public int SellerID { get; set; }
        public int BuyerID { get; set; }
        public decimal Price { get; set; }
        [StringLength(40, ErrorMessage = "Ошибка. Информация о сотруднике не должена занимать больше 40 символов")]
        public string Employer { get; set; }
        //связи с остальными таблицами
        public ICollection<ServesType> ServerTypes { get; set; }
        public virtual Seller Seller { get; set; }
        public virtual Buyer Buyer { get; set; }
    }
}