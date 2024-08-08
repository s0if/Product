using create_product.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace create_product.Context
{
    internal class ProductContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=Saifaldin\\SQLEXPRESS02;Database=CreateProduct;Trusted_Connection=true;TrustServerCertificate=True");
        }
        public DbSet<Product> Products { get; set; }
    }
}
