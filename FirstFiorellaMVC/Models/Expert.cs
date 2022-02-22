using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstFiorellaMVC.Models
{
    public class Expert
    {
        public int Id { get; set; }

        [Required]
        [StringLength(maximumLength:150)]
        public string Name { get; set; }

        public string Image { get; set; }

        [NotMapped]
        [Required]
        public IFormFile Photo { get; set; }

        [Required, ForeignKey("Position")]
        public int PositionId { get; set; }

        public Position Position { get; set; }
    }
}
