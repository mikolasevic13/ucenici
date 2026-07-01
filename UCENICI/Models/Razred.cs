using System.ComponentModel.DataAnnotations;

namespace UCENICI.Models
{
    public class Razred
    {
        public int RazredId { get; set; }
        [Required]
        public string RazredNaziv { get; set; } = string.Empty;
        [Required]
        public string Razrednik { get; set; } = string.Empty;
        [Required]
        public int RazredBrojUcenika { get; set; }
    }
}
