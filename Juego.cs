using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OrientadaObjetos
{
    public class Juego
    {
        public void adivinanza(int numero)
        {
            bool correcto = false;
            Console.WriteLine("TIENES 5 INTENTOS");
            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine("Intento numero " + i);
                Console.WriteLine("\n");
                Console.WriteLine("Ingrese numero");
                int numUsuario = int.Parse(Console.ReadLine());

                

                if (numUsuario < numero)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Tu numero es menor que el adivinado");
                    


                }
                else if (numUsuario > numero)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Tu numero es mayor que el adivinado");
                  

                }
                else
                {
                     correcto = true;
                    break;
                }

            }
            if (correcto) {
                Console.WriteLine("\n");
                Console.WriteLine("tu numero es CORRECTO");
            }
            else
            {
                Console.WriteLine("\n");
                Console.WriteLine("FALLASTES!!  se te acabaron las oportunidades");
            }

        }

    }
}


