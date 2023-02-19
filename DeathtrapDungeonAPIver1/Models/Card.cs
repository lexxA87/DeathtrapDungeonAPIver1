using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeathtrapDungeonAPIver1.Models
{
    public class Card
    {
        public int Id { get; set; }

        [Key]
        [Column(TypeName = "SMALLINT")]
        public int Number { get; set; }

        [Required]
        [Column(TypeName = "NVARCHAR")]
        public string Description { get; set; } = string.Empty;

        public int[]? GoToNumber { get; set; }
    }
}
