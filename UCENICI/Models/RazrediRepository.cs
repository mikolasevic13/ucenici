namespace UCENICI.Models
{
    public static class RazrediRepository
    {
        private static List<Razred> _razredi = new List<Razred>()
        {
            new Razred { RazredId = 1, RazredNaziv = "1A", Razrednik = "Ivan Ivić", RazredBrojUcenika=19 },
            new Razred { RazredId = 2, RazredNaziv = "2B", Razrednik = "Petar Horvat", RazredBrojUcenika=20 },
            new Razred { RazredId = 3, RazredNaziv = "3C", Razrednik = "Stjepan Mikić", RazredBrojUcenika=16 }
        };

        public static void AddRazred(Razred razred)
        {
            var maxId = _razredi.Max(x => x.RazredId);
            razred.RazredId = maxId + 1;
            _razredi.Add(razred);
        }

        public static List<Razred> GetRazredi() => _razredi;

        public static Razred? GetRazredById(int razredId)
        {
            var razred = _razredi.FirstOrDefault(x => x.RazredId == razredId);
            if (razred != null) 
            { 
                return new Razred
                {
                    RazredId = razred.RazredId,
                    RazredNaziv = razred.RazredNaziv,
                    Razrednik = razred.Razrednik,
                    RazredBrojUcenika = razred.RazredBrojUcenika,
                };
            }

            return null;
        }

        public static void UpdateRazred(int razredId, Razred razred)
        {
            if (razredId != razred.RazredId) return;

            var razredToUpdate = _razredi.FirstOrDefault(x => x.RazredId == razredId);
            if (razredToUpdate != null)
            {
                razredToUpdate.RazredNaziv = razred.RazredNaziv;
                razredToUpdate.Razrednik = razred.Razrednik;
                razredToUpdate.RazredBrojUcenika = razred.RazredBrojUcenika;
            }
        }

        public static void DeleteRazred(int razredId)
        {
            var razred = _razredi.FirstOrDefault(x => x.RazredId == razredId);
            if (razred != null)
            {
                _razredi.Remove(razred);
            }
        }
    }
}
