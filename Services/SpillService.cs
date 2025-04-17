using System.Collections.Generic;
using Oblig1_261667.Models;

namespace Oblig1_261667.Services
{
    public class SpillService
    {
        private static List<Rute> _spill;

        public SpillService()
        {
            if (_spill == null || _spill.Count == 0)
            {
                StartNyttSpill();
            }
        }

        public List<Rute> HentSpill()
        {
            return _spill;
        }

        public void FjernRute(int id)
        {
            var rute = _spill.Find(r => r.Id == id);
            if (rute != null)
            {
                _spill.Remove(rute);
            }
        }

        public bool AlleRuterFjernet()
        {
            return _spill.Count == 0;
        }

        public void StartNyttSpill()
        {
            _spill = new List<Rute>();

            // Legg til ruter (f.eks. 3x3 brett = 9 ruter)
            for (int i = 1; i <= 9; i++)
            {
                _spill.Add(new Rute { Id = i, Innhold = $"Rute {i}" });
            }
        }
    }
}
