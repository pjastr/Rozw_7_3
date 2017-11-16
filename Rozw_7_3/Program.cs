using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozw_7_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj rok");
            int rok = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj miesiac");
            int miesiac = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj dzien");
            int dzien = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj godzina");
            int godzina = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj minuty");
            int minuty = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj sekundy");
            int sek = Convert.ToInt32(Console.ReadLine());

            DateTime data = new DateTime(rok, miesiac, dzien, godzina, minuty, sek);
            Console.WriteLine(data.ToString());

            Console.ReadKey();
        }
    }
}
