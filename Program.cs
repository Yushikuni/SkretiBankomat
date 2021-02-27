using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat
{
    class Program
    {
        static void Main(string[] args)
        {

            /* zadání:
            vyvoř banokomat s počáteční hodnotou vkladu: 1 000 000
            dále pak vytvoř proměnné pro vklad.
            zvol vhodný datový typ proměnných*/


            double pocatecniHodnota = 1000000;
            double aktualniHodnota = -1;
            double vklad = -1;

            Console.WriteLine("Vítejte v banokomatu...\nzůstatek na účtu: " + pocatecniHodnota.ToString());

            Console.WriteLine("Zadej částku: ");
            vklad = int.Parse(Console.ReadLine());
            aktualniHodnota = pocatecniHodnota + vklad;

            Console.WriteLine("Vítejte v banokomatu...\nzůstatek na účtu: " + aktualniHodnota.ToString());
            Console.ReadLine();

        }
    }
}
