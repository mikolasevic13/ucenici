namespace UCENICI.Models
{
    public class UceniciRepository
    {
        private static List<Ucenik> _ucenici = new List<Ucenik>()
        {
            new Ucenik { UcenikId = 1, RazredId = 1, Ime = "Josip", Prezime="Horvat", ImeOcaMajke="David", PrezimeOcaMajke="Horvat", OIB=23598764192, DatumRodenja=new DateTime(2007,9,12)},
            new Ucenik { UcenikId = 2, RazredId = 2, Ime = "Ivan", Prezime="Marinović", ImeOcaMajke="Davor", PrezimeOcaMajke="Marinović", OIB=89762485315, DatumRodenja=new DateTime(2008,2,13)},
            new Ucenik { UcenikId = 3, RazredId = 3, Ime = "Mario", Prezime="Matić", ImeOcaMajke="Ivana", PrezimeOcaMajke="Ivić",   OIB=95135726485, DatumRodenja=new DateTime(2007,4,22)},
            new Ucenik { UcenikId = 4, RazredId = 4, Ime = "Luciano", Prezime="Peregrino", ImeOcaMajke="Vicenzo", PrezimeOcaMajke="Peregrino",  OIB=59713268459, DatumRodenja=new DateTime(2007,11,27)}
        };

        public static void AddUcenik(Ucenik ucenik)
        {
            var maxId = _ucenici.Max(x => x.UcenikId);
            ucenik.UcenikId = maxId + 1;
            _ucenici.Add(ucenik);
        }

        public static List<Ucenik> GetUcenici(bool loadRazred=false)
        {
            if(!loadRazred)
            {
                return _ucenici;
            }
            else
            {
                if(_ucenici != null && _ucenici.Count>0)
                {
                    _ucenici.ForEach(x =>
                    {
                        if (x.RazredId.HasValue)
                            x.Razred = RazrediRepository.GetRazredById(x.RazredId.Value);
                    });
                }
                return _ucenici??new List<Ucenik>();
            }
        }

        public static Ucenik? GetUcenikById(int ucenikId, bool loadRazred=false)
        {
            var ucenik = _ucenici.FirstOrDefault(x => x.UcenikId == ucenikId);
            if (ucenik != null)
            {
                var ucen= new Ucenik
                {
                    UcenikId = ucenik.UcenikId,
                    RazredId = ucenik.RazredId,
                    Ime = ucenik.Ime,
                    Prezime = ucenik.Prezime,
                    ImeOcaMajke = ucenik.ImeOcaMajke,
                    PrezimeOcaMajke = ucenik.PrezimeOcaMajke,
                    OIB = ucenik.OIB,
                    DatumRodenja = ucenik.DatumRodenja
                };
                if(loadRazred && ucen.RazredId.HasValue)
                {
                    ucen.Razred = RazrediRepository.GetRazredById(ucen.RazredId.Value);
                }
            }

            return null;
        }

        public static void UpdateUcenik(int ucenikId, Ucenik ucenik)
        {
            if (ucenikId != ucenik.UcenikId) return;

            var ucenikToUpdate = _ucenici.FirstOrDefault(x => x.UcenikId == ucenikId);
            if (ucenikToUpdate != null)
            {
                ucenikToUpdate.RazredId = ucenik.RazredId;
                ucenikToUpdate.Ime = ucenik.Ime;
                ucenikToUpdate.Prezime = ucenik.Prezime;
                ucenikToUpdate.ImeOcaMajke = ucenik.ImeOcaMajke;
                ucenikToUpdate.PrezimeOcaMajke = ucenik.PrezimeOcaMajke;
                ucenikToUpdate.OIB = ucenik.OIB;
                ucenikToUpdate.DatumRodenja = ucenik.DatumRodenja;


            }
        }

        public static void DeleteUcenik(int ucenikId)
        {
            var ucenik = _ucenici.FirstOrDefault(x => x.UcenikId == ucenikId);
            if (ucenik != null)
            {
                _ucenici.Remove(ucenik);
            }
        }
    }
}

