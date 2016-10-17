using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RealtorCompany.Models
{
    public class ServesType
    {
        public int ServesTypeID { get; set; }
        public string Name { get; set; }
        public string Discription { get; set; }
        public decimal Money { get; set; }
        //Определение связей в БД
        public ICollection<ServesType> ServerTypes { get; set; }
    }
}