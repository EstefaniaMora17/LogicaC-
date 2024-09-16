using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientadaObjetos
{
    public class MaquinaExpendedora
    {
       public double total;
       public int contadorRefrescos = 0, contadorAguas = 0, contadorJugos = 0;
        public void ExpendedoraBebidas()
        {
            int opcion;
            Console.WriteLine("Bienvenido a la Maquina Expendedora de bebidas ");
            Console.WriteLine("\n");
            Console.WriteLine("Opciones de bebedidas: ");
            Console.WriteLine("\n");
            Console.WriteLine(" 1) Refreso - $1,50 ");
            Console.WriteLine(" 2) Agua - $1.00");
            Console.WriteLine(" 3) Jugo - $2.00 ");
            Console.WriteLine("\n");

            do
            {
                Console.WriteLine("Ingrese numero de la bebida que desea comprar (1-3), o ingrese 0 para salir");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 0:
                        resumenCompra();
                        break;
                    case 1:
                        Console.WriteLine("¡Refresco seleccionado! Costo actual: $1.50");
                        Console.WriteLine("\n");
                        double refresco = 1.50;
                        total += refresco;
                        contadorRefrescos++;
                        break;
                    case 2:
                        Console.WriteLine("¡Agua seleccionada! Costo actual: $2.50");
                        Console.WriteLine("\n");
                        double agua = 2.50;
                        total += agua;
                        contadorAguas++;    
                        break;
                    case 3:
                        Console.WriteLine("¡Jugo seleccionado! Costo actual: $4.50");
                        Console.WriteLine("\n");
                        double jugo = 4.50;
                        total += jugo;
                        contadorJugos++;    
                        break;
                    default: 
                        Console.WriteLine("¡Opción inválida! Por favor, ingrese un número entre 1 y 3.");
                        Console.WriteLine("\n");
                        break;

                }
            } while (opcion > 0);

          
            
        }
        public void resumenCompra()
        {
            Console.WriteLine("Resumen de la compra: ");
            Console.WriteLine("Refrescos seleccionados: "+contadorRefrescos);
            Console.WriteLine("Aguas seleccionadas: "+contadorAguas);
            Console.WriteLine("Aguas seleccionadas: " + contadorJugos);

            Console.WriteLine("\n");

            Console.WriteLine("Costo total : $"+total);

            Console.WriteLine("\n");

            Console.WriteLine("¡Gracias por usar la Máquina Expendedora de Bebidas!");
        }
    }
}


