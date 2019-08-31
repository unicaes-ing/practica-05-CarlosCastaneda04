using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 1
            DateTime hoy = DateTime.Today;
            DateTime año = DateTime.Parse("31/12/2019");
            Console.WriteLine("Días que faltan para terminar el año: " + dias(hoy, año));
            Console.ReadKey();
        }

        static int dias(DateTime hy, DateTime year)
        {
            int dias = year.DayOfYear - hy.DayOfYear;

            return dias;
        }
    }
}
