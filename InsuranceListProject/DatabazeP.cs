using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceListProject
{
    class DatabazeP
    {
        private List<Zaznam> _zaznamy { get; set; } = new List<Zaznam>();

        public void PridejZaznam(Zaznam zaznam)
        {
            _zaznamy.Add(zaznam);
        }

        public void VypisVsechny()
        {
            foreach(var zaznam in _zaznamy) 
            {
                Console.WriteLine($"Zaznam: {zaznam.Jmeno}, {zaznam.Prijmeni}, {zaznam.Vek}, {zaznam.TelCislo}");
            }
        }

        public void VypisOdpovidajici(string hledaneJmeno, string hledanePrijmeni)
        {

            var odpovidajiciZaznamy = _zaznamy.Where(z => z.Jmeno == hledaneJmeno && z.Prijmeni == hledanePrijmeni).ToList();

            if (odpovidajiciZaznamy != null)
            {
                foreach (var zaznam in odpovidajiciZaznamy)
                {
                    Console.WriteLine($"Zaznam: {zaznam.Jmeno}, {zaznam.Prijmeni}, {zaznam.Vek}, {zaznam.TelCislo}");
                }
            }
        }


    }
}
