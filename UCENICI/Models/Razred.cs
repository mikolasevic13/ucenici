namespace UCENICI.Models
{
    public class Razred
    {
        public int RazredId { get; set; }
        public string RazredNaziv { get; set; } = string.Empty;

        public string Razrednik { get; set; } = string.Empty;

        public int RazredBrojUcenika { get; set; }
    }
}
