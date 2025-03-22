using System.ComponentModel.DataAnnotations;
namespace mission07.Models
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        public string Director { get; set; }

        [Required]
        public string Genre { get; set; }

        [Required]
        public string Rating { get; set; }

        public bool? Edited { get; set; } // Nullable since it's optional
        public string? LentTo { get; set; } // Nullable since it's optional

        [MaxLength(25)]
        public string? Notes { get; set; } // Nullable since it's optional
    }
}