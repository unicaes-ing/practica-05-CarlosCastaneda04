using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_5
{
    class Ejercicio_5
    {
        static void Main(string[] args)
        {
            //Ejercicio 5
            decimal precio, por = 0;
            bool r = false;
            Console.Write("Precio del Producto: $");
            do
            {
                if (decimal.TryParse(Console.ReadLine(), out precio) && precio >= 0)
                {
                    Console.Write("Descuento del Producto (%): ");
                    do
                    {
                        r = false;
                        if (decimal.TryParse(Console.ReadLine(), out por) && por >= 0 && por <= 100)
                        {
                            Console.WriteLine("Precio a Pagar: " + descuento(precio, por).ToString("C2"));
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("ingrese un entero entre 0 y 100 : ");
                            r = true;
                        }
                    } while (r == true);
                }
                else
                {
                    Console.WriteLine("ingrese un decimal positivo : ");
                    r = true;
                }

            } while (r == true);
        }


        static decimal descuento(decimal p, decimal pc)
        {
            decimal desc = 0;
            pc = pc / 100;
            desc = p * pc;
            p = p - desc;
            return p;
        }
    }
}
