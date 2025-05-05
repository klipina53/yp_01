
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace yp02.Classes.Context
{
    public class Contexts : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql(
                    "server=127.0.0.1;port=3306;uid=root;database=base2;",
                    new MySqlServerVersion(new Version(8, 0, 11)) // Убедитесь, что версия соответствует вашей
                );
            }
        }
        
        public DbSet<Materials> Materials { get; set; }
        public DbSet<Partner_Products> Partner_Products { get; set; }
        public DbSet<Partners> Partners { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Required_Material> Required_Material { get; set; }
        public DbSet<Suppliers> Suppliers { get; set; }
        public DbSet<Type_Partner> Type_Partner { get; set; }
        public DbSet<Type_Product> Type_Product { get; set; }
        public DbSet<GetChanges> GetChanges { get; set; }
        public Contexts() { }

      
    }
}

