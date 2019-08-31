using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_5
{
    class Ejercicio_6
    {
        static void Main(string[] args)
        {
            //Ejercicio 6
            int c;
            bool rep = false;
            decimal sum = 0;
            Console.Write("Cantidad de Estudiantes: ");
            do
            {
                if (int.TryParse(Console.ReadLine(), out c) && c >= 0)
                {
                    decimal[] notas = new decimal[c];
                    rep = false;
                    for (int i = 0; i <= c - 1; i++)
                    {
                        Console.WriteLine("*******************************************************************");
                        Console.WriteLine("Nota del Estudiante #" + (i + 1));
                        do
                        {
                            if (decimal.TryParse(Console.ReadLine(), out notas[i]) && notas[i] >= 0 && notas[i] <= 10)
                            {

                                sum = sum + notas[i];
                                rep = false;
                            }
                            else
                            {
                                Console.WriteLine("Ingrese un decimal positivo entre 0 y 10 :(");
                                rep = true;
                            }
                        } while (rep == true);

                    }
                }
                else
                {
                    Console.WriteLine("Ingrese un entero positivo : ");
                    rep = true;
                }
            } while (rep == true);
            Console.WriteLine("===============================================================");
            Console.WriteLine("Promedio del Examen: " + promedio(sum, c).ToString("N2"));
            Console.WriteLine("===============================================================");
            Console.ReadKey();
        }

        static decimal promedio(decimal s, int c)
        {
            decimal prom = s / c;
            return prom;
        }
    }
}
