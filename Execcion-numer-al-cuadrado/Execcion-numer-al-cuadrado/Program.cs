using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execcion_numer_al_cuadrado
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int num1;
                double cuadrado;
                Console.WriteLine("--Calculo de un numero al cuadrado--");
                Console.Write("Ingrese un numero");
                num1 = int.Parse(Console.ReadLine());
                cuadrado = Math.Pow(num1, 2);
                Console.WriteLine("Resultado: {0}", cuadrado);
                Console.WriteLine("Precione enter para salir");
                Console.ReadLine();
            }
            catch(FormatException e)
            {
                Console.Write(e.Message);
            }
            catch(OverflowException x)
            {
                Console.Write(x.Message);
            }
        }
    }
}
