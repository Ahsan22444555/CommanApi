using System.ComponentModel.DataAnnotations;

namespace CommandApi.Models
{
    public class Command
    {
        [Required]
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(251)]
        public string HowTo { get; set; }

        [Required]
        public string Platform { get; set; }

        [Required]
        public string CommandLine { get; set; }
    }
}