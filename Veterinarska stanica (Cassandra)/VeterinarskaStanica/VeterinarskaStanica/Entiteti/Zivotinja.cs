using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinarskaStanica.Entiteti
{
    public class Zivotinja
    {
        public int vlasnikId { get; set; }
        public int id { get; set; }
        public string ime { get; set; }
        public string datumRodjenja { get; set; }
        public string vrsta { get; set; }

    }
}
