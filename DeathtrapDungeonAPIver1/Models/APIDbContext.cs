using Microsoft.EntityFrameworkCore;

namespace DeathtrapDungeonAPIver1.Models
{
    public class APIDbContext : DbContext
    {
        public APIDbContext(DbContextOptions option) : base(option) { }

        public DbSet<Card> Cards { get; set; }
    }
}
