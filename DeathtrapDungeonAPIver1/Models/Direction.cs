using System.ComponentModel.DataAnnotations;

namespace DeathtrapDungeonAPIver1.Models
{
    public class Direction
    {
        [Key]
        public Guid Id { get; set; }
        // public int Id { get; set; }
        // public Guid DirectionId { get; set; }


        [Required]
        public string Description { get; set; } = string.Empty;

        [Required]
        public int CardId { get; set; }
    }
}
