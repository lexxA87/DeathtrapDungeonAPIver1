using System.ComponentModel.DataAnnotations;

namespace DeathtrapDungeonAPIver1.Models
{
    public class Direction
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Description { get; set; } = string.Empty;

        [Required]
        public int NumberCard { get; set; }

        [Required]
        public int CardId { get; set; }
    }
}
