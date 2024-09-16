using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientadaObjetos
{
    internal class TablaMultipicar
    {
        public void multiplicacion() {

            Console.WriteLine("Ingresa numero por el cual quieres multiplicar");
            int numero = int.Parse(Console.ReadLine());
            for (int power = 1; power <= 10; power++)
            {
                Console.WriteLine($"{numero}x{power} = {numero * power}");
            }
            

        }
    }
}
