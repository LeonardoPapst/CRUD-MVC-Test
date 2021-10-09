using CRUD_MVC_Test.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CRUD_MVC_Test.DAL
{
    public class EFContext: DbContext
    {
        public EFContext() : base("EFConnectionString") { }
        public DbSet<Pessoa> Pessoas { get; set; }
    }
}