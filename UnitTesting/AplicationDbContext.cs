using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    public class AplicationDbContext : DbContext
    {
        public DbSet<CurrencyConversion> CurrencyConversions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=;Database=CurrencyConversion;trusted_connection=true;TrustServerCertificate=True;");
        }
    }

    public class CurrencyConversion
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public decimal EuroAmount { get; set; }
        public decimal UsdAmount { get; set; }
        public decimal GbpAmount { get; set; }
        public decimal JpyAmount { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
