using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientadaObjetos
{
    public class Euros
    {
        public void capitalInicial() {

            double cantidadEuros,tasaInteres,NumAños;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese la cantidad de euros");
                cantidadEuros= double.Parse(Console.ReadLine());    
                Console.WriteLine("Ingrese la tasa de interes");
                tasaInteres = double.Parse(Console.ReadLine());
                Console.WriteLine("ingrese el numero de años");
                NumAños = double.Parse(Console.ReadLine());

               double capitalInicial = cantidadEuros*( Math.Pow(1 + (tasaInteres / 100), NumAños));

                Console.WriteLine(capitalInicial);
            }
        }
    }
}
