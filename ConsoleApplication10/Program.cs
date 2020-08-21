using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int aux = 0;
            Random r = new Random();
            int aleatorio = r.Next(1, 10000);
            do
            {
                Console.WriteLine("Indica el numero que creas: ");
                numero = Convert.ToInt32(Console.ReadLine());
                if (numero == aleatorio)
                {
                    Console.WriteLine("Correcto, has acertado el numero");
                    aux = 14;
                }
                else
                if (numero < aleatorio)
                    Console.WriteLine("Prueba un numero mas alto");
                if (numero > aleatorio)
                    Console.WriteLine("Prueba un numero mas bajo");

                aux = aux + 1;
            } while (aux < 13);

            if (aux != 15)
                Console.WriteLine("No has acertado, era {0}", aleatorio);
            Console.ReadKey();
        }
    }
}
