using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RealtorCompany.Models
{
    public class RealtorCompany_DBContext : DbContext
    {
        //необходимо написать строку подключения в Web.config
        public RealtorCompany_DBContext()
            : base("name=RealtorCompany_DBContext")
        { }
        public DbSet<ServerTypeContractConnection> ServerTypeContractConnection { get; set; }
        public DbSet<ServesType> ServessType { get; set; }
    }
}