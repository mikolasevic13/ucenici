using System.ComponentModel.DataAnnotations;

namespace UCENICI.Models
{
    public class Ucenik
    {
        public int UcenikId { get; set; }

        [Required]
        [Display(Name = "Razred")]
        public int? RazredId { get; set; }

        [Required]
        public string Ime { get; set; } = string.Empty;

        [Required]
        public string Prezime { get; set; } = string.Empty;

        [Required]
        public string ImeOcaMajke { get; set; } = string.Empty;

        [Required]
        public string PrezimeOcaMajke { get; set; } = string.Empty;

        [Required]
        public long? OIB { get; set; }

        [Required]
        public DateTime DatumRodenja { get; set; }

        public Razred? Razred { get; set; }

    }
}
