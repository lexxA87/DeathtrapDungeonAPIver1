using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeathtrapDungeonAPIver1.Models
{
    public class Card
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        //public int CardId { get; set; }

        [Required]
        public string Description { get; set; } = string.Empty;

        // public int[]? GoToNumber { get; set; }

        public List<Direction> Directions { get; set; } = new();
    }
}
