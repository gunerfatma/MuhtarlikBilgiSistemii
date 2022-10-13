using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context: DbContext
    {
        public DbSet<Muhtar> Muhtars { get; set; }
        public DbSet<Mahalle> Mahalles { get; set; }
        public DbSet<Envanter> Envanters { get; set; }
        public DbSet<OnemliMekanlar> OnemliMekanlars { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Hizmetler> Hizmetlers { get; set; }


    }
}
