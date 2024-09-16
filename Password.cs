using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientadaObjetos
{
    public class Password
    {
        public void ValidarPassword()
        {

            string password1, password2;
            Console.WriteLine("TIENES 3 INTENTOS");
         

            password1 = "EMM11*";


            for (int i = 0; i <= 3; i++)
            {
                
                Console.WriteLine((i != 0) ? "Intento numero " + (i) : "" );
               
                Console.WriteLine("Validar Contraseña");

                password2 = Console.ReadLine();
             
                if (password1 == password2)
                {
                    Console.WriteLine("Contraseña Correcta");
                    break;
                }
                if(i ==3)
                {
                    Console.WriteLine("Se te acaron las oportunidades");
                }
            }

        }
    }
}
