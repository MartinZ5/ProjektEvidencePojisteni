using System.Collections.Concurrent;

namespace InsuranceListProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Evidence Pojištěných");
            Console.WriteLine("--------------------------------");

            DatabazeP databazeP = new DatabazeP();
            char volba = '0';
            //hlavní cyklus
            while (volba != '4')
            {
                Console.WriteLine();
                Console.WriteLine("Vyberte si akci:");
                Console.WriteLine("1 - Přidat nového pojištěného");
                Console.WriteLine("2 - Vypsat všechny pojištěné");
                Console.WriteLine("3 - Vyhledat pojištěného(dle jména a příjmení)");
                Console.WriteLine("4 - Konec");

                volba = Console.ReadKey().KeyChar;
                 Console.WriteLine();
                 //reakce na volbu
                 switch(volba)
                 {
                     case '1':
                         Console.WriteLine("Zadej jméno:");
                        string jmeno = Console.ReadLine().Trim();
                        while(string.IsNullOrWhiteSpace(jmeno))
                        {
                            Console.WriteLine("Zadej text znovu:");
                            jmeno = Console.ReadLine().Trim();
                        }
                         Console.WriteLine("Zadej příjmení:");
                        string prijmeni = Console.ReadLine().Trim();
                        while (string.IsNullOrWhiteSpace(prijmeni))
                        {
                            Console.WriteLine("Zadej text znovu:");
                            prijmeni = Console.ReadLine().Trim();
                        }
                        Console.WriteLine("Zadej věk:");
                         int vek = int.Parse(Console.ReadLine().Trim());
                        Console.WriteLine("Telefonní číslo:");
                         string telCislo = Console.ReadLine().Trim();

                         var novyZaznam = new Zaznam(jmeno, prijmeni, vek, telCislo);
                         databazeP.PridejZaznam(novyZaznam);
                         break;

                     case '2':
                        databazeP.VypisVsechny();
                         break;

                     case '3':
                        Console.WriteLine("Jaké jméno hledáš?");
                        string hledaneJmeno = Console.ReadLine();  
                        Console.WriteLine("Příjmení:");
                        string hledanePrijmeni = Console.ReadLine();
                        databazeP.VypisOdpovidajici(hledaneJmeno, hledanePrijmeni);
                         break;

                     case '4':
                        Console.WriteLine("Libovolnou klávesou ukončíte program...");
                         break;

                     default:
                         Console.WriteLine("Neplatná volba, stiskněte libovolnou klávesu a opakujte volbu.");
                         break; 
                 }
             }
        }
    }
}