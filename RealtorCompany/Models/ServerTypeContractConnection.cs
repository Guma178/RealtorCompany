using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RealtorCompany.Models
{
    public class ServerTypeContractConnection
    {
        public int ConnectionID { get; set; }
        public int? ServerTypeID { get; set; }
        public int? Counter { get; set; }
        public decimal Price { get; set; }
        //Определение отношений в БД
        public virtual ServesType ServerType { get; set; }


    }
}