using Finance.Data.Entities;
using Finance.Data.Mappings;
using Microsoft.EntityFrameworkCore;

namespace Finance.Data
{
    public class FinanceContext : DbContext
    {
        public FinanceContext(DbContextOptions<FinanceContext> options) : base(options) { }

        public DbSet<Money> Moneys { get; set; }
        public DbSet<Payment> Payments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MoneyMap());
            modelBuilder.ApplyConfiguration(new PaymentMap());
        }
    }
}
