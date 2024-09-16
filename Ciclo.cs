using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientadaObjetos
{
    public class Ciclo
    {
        public void numeroCiclo()
        {

             int numero = 0;

            do
            {


                Console.WriteLine("Ingrese numero");
                numero = int.Parse(Console.ReadLine());

                if (numero == 10 || numero > 10)
                {

                    Console.WriteLine("Your number was at least 10.");

                }
                else
                {
                    Console.WriteLine("Your number was less than lest 10");
                }
            } while (numero < 10);


        }
    }
}
