using Microsoft.EntityFrameworkCore;
using Abc.Data.Quantity;

namespace Abc.Infra.Quantity
{
    public class QuantityDbContext : DbContext
    {
        public DbSet<MeasureData> Measures { get; set; }
        public QuantityDbContext(DbContextOptions<QuantityDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            InitializeTables(builder);
        }
        public static void InitializeTables(ModelBuilder builder)
        {
            builder.Entity<MeasureData>().ToTable(nameof(Measures));
        }
    }
}
