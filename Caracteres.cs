using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientadaObjetos
{
    public class Caracteres
    {
        public void CaracteresChar()
        {
            char letras;

            while (true) {

                Console.WriteLine("Ingrese caracteres ");
                letras = char.Parse(Console.ReadLine());


                if(letras == 'q')
                {
                    break;
                   
                }
                Console.WriteLine("Caracteres Ingresados = " + letras);
            }
        }
    }
}
