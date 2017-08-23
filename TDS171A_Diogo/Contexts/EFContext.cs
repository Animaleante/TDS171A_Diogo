using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using TDS171A_Diogo.Models;

namespace TDS171A_Diogo.Contexts
{
    public class EFContext : DbContext
    {
        public EFContext() : base("Aps_Net_MVC_CS") { }

        public DbSet<Category> Categorias { get; set; }
        public DbSet<Fabricante> Fabricantes { get; set; }
    }
}