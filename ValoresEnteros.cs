using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OrientadaObjetos
{
    public class ValoresEnteros
    {
       
        public void enteros()
        {
            double R=0, T =0, Q = 0; 
            


            for (int i = 0; i <=5; i++)
            {
                Console.WriteLine("Ingrese Numero R");
                R =int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese Numero T");
                T = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese Numero Q");
                Q = int.Parse(Console.ReadLine());

               R = Math.Pow(R, 4);
               T= Math.Pow(T, 3);
               Q= Math.Pow(Q, 2);

                double operacion = R - T + 4 * Q;
                if (operacion < 820)
                {
                    Console.WriteLine("los valores satifacen la exprecion");
                }
                else
                {
                    Console.WriteLine("los valores no satifacen la exprecion");
                }

            }
          
        }
    }
}
