using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.SqlClient;
using System.IO;

namespace RealtorCompany.Models
{
    public class DB_Initilizer : CreateDatabaseIfNotExists<RealtorCompany_DBContext>
    {
        protected override void Seed(RealtorCompany_DBContext context)
        {
            //Переопределить сид
            base.Seed(context);
            //Как заполнить DBContext данными с помощю SQL скрипта?
        }
    }
}