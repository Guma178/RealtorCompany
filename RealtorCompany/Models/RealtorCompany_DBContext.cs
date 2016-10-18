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
            : base("name=RealtorCompany_DBContext") //База должна существовать или она создастся по модели в DB_Initilizer? 
        { }
        public DbSet<ServerTypeContractConnection> ServerTypeContractConnection { get; set; }
        public DbSet<ServesType> ServessType { get; set; }
        public DbSet<Contract> Contract { get; set; }
        public DbSet<Buyer> Buyer { get; set; }
        public DbSet<FlatType> FlatType { get; set; }
        public DbSet<Flat> Flat { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<WantedFlat> WantedFlat { get; set; }
    }
}