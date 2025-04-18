using System.Collections.Generic;
using Oblig1_261667.Models;

using Oblig1_261667.Models;

namespace Oblig1_261667.Services
{
    public class SpillService
    {
        private List<Rute> _spill = new();
        public Bruker AktivBruker { get; private set; } = new Bruker();

        public SpillService()
        {
            StartNyttSpill();
        }

        public void StartNyttSpill()
        {
            _spill = LagNyttSpill();
        }

        public void FjernRute(int id)
        {
            var rute = _spill.FirstOrDefault(r => r.Id == id);
            if (rute != null)
            {
                _spill.Remove(rute);
            }
        }

        public bool AlleRuterFjernet()
        {
            return _spill.Count == 0;
        }

        public List<Rute> HentSpill()
        {
            return _spill;
        }

        public void OppdaterBruker(string navn)
        {
            AktivBruker.Navn = navn;
            AktivBruker.AntallFullførteSpill++;
        }

        private List<Rute> LagNyttSpill()
        {

            return Enumerable.Range(1, 16).Select(id => new Rute { Id = id, Innhold = "?" }).ToList();
        }
    }
}
