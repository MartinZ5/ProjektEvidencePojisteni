using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceListProject
{
    class Zaznam
    {
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public int Vek { get; set; }
        public string TelCislo { get; set; }

        public Zaznam(string jmeno, string prijmeni, int vek, string telCislo)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Vek = vek;
            TelCislo = telCislo;
        }
    }
}
