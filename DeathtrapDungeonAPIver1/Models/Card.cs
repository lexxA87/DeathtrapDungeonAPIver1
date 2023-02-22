using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeathtrapDungeonAPIver1.Models
{
    public class Card
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        public string Description { get; set; } = string.Empty;

        // for converter in APIDbContext
        // public int[]? GoToNumber { get; set; }

        public List<Direction> Directions { get; set; } = new();
    }
}
