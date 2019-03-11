using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinarskaStanica.Entiteti
{
    public class Izvestaj
    {
        public int id { get; set; }
        public int doktorId { get; set; }
        public int ordinacijaId { get; set; }
        public int zivotinjaId { get; set; }
        public string izvestaj { get; set; }
        public string datum { get; set; }
        public string vrstaIntervencije { get; set; }

    }
}
