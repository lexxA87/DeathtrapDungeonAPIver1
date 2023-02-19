using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DeathtrapDungeonAPIver1.Models
{
    public class APIDbContext : DbContext
    {
        public APIDbContext(DbContextOptions option) : base(option) { }

        public DbSet<Card> Cards { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var converter = new ValueConverter<int[], string>(
                v => string.Join(";", v),
                v => v.Split(";", StringSplitOptions.RemoveEmptyEntries).Select(val => int.Parse(val)).ToArray());

            modelBuilder.Entity<Card>()
                .Property(e => e.GoToNumber)
                .HasConversion(converter);
        }
    }
}
