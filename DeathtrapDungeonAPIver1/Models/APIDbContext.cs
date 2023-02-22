using Microsoft.EntityFrameworkCore;

namespace DeathtrapDungeonAPIver1.Models
{
    public class APIDbContext : DbContext
    {
        public APIDbContext(DbContextOptions option) : base(option) { }

        public DbSet<Direction> Directions { get; set; }

        public DbSet<Card> Cards { get; set; }

        // Conerter from "1;2;3" in DB to [1, 2, 3] in out json

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    var converter = new ValueConverter<int[], string>(
        //        v => string.Join(";", v),
        //        v => v.Split(";", StringSplitOptions.RemoveEmptyEntries).Select(val => int.Parse(val)).ToArray());

        //    modelBuilder.Entity<Card>()
        //        .Property(e => e.GoToNumber)
        //        .HasConversion(converter);
        //}
    }
}
