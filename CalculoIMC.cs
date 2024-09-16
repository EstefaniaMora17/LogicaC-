using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientadaObjetos
{
    public class CalculoIMC
    {

        public void MasaCorporal()
        {
            double estatura;
            double masaCorporal;
            int peso;

            for (int i = 0; i < 5; i++) {
                Console.WriteLine("Ingrese Peso  ");
                peso = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese Estatura  " );
                estatura= double.Parse(Console.ReadLine());

              
                masaCorporal  = peso / (estatura * estatura);
                Console.WriteLine(masaCorporal);
            }
        }
    }
}
