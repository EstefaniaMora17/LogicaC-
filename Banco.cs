using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientadaObjetos
{
    public class Banco
    {
       public  int numSinCredito = 0, numCreditoHijos = 0, numCreditoSuperior = 0, numCredito = 0;
        public void  prestamo() {

            int contador = 0;
            float ingresos = 0;
            int hijos = 0;


            while (contador < 5) {

                Console.WriteLine("¿Cuales son tus ingresos anuales ? ");
                ingresos = float.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa el numero de Hijos  ");
                hijos = int.Parse(Console.ReadLine());
                contador++;

                ValidPrestamo(ingresos,hijos,contador);
            }
            

        }
        public void ValidPrestamo(float ingresos, int hijos, int contador)
        {
          
            if (ingresos >= 12000 && hijos == 0) {

                numCreditoSuperior++;
                Console.WriteLine("\n");
                Console.WriteLine("*** Se concede el credito ***");
               
            }
            else if(ingresos ==11000 && hijos <= 2)
            {
                numCreditoHijos++;
                Console.WriteLine("\n");
                Console.WriteLine("*** Se concede el credito ***");
            }
            else if ((ingresos == 8000 || ingresos == 10000) && hijos == 0 )
            {
                numCredito++;
                Console.WriteLine("\n");
                Console.WriteLine("*** Se concede el credito ***");
            }
            else
            {
                numSinCredito++;
                Console.WriteLine("\n");
                Console.WriteLine("*** No se concede el credito ***");
            }

           
        }
        public void Reporte()
        {
            Console.WriteLine("\n");
            Console.WriteLine("***REPORTE CREDITO***");
            Console.WriteLine("\n");
            Console.WriteLine("Cantidad de clientes sin creditos comedidos " + numSinCredito );
            Console.WriteLine("\n");
            Console.WriteLine("Cantidad de clientes con ingresos superios a 12000 " + numCreditoSuperior);
            Console.WriteLine("\n");
            Console.WriteLine("Cantidad de clientes con ingresos inferiores a 12000 pero superiores a 10000 y maximo 2 hijos" + numCreditoHijos);
            Console.WriteLine("\n");
            Console.WriteLine("Cantidad de clientes con ingresos entre 800 y 10000 " + numCredito);
        }
    }
}
