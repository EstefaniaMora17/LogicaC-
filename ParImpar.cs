using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientadaObjetos
{
    public class ParImpar
    {
        public void parImpar()
        {
            int num;

            do
            {
                Console.WriteLine("ingresa un numero ");
                 num = int.Parse(Console.ReadLine());
                if (num % 2 == 0)
                {
                    Console.WriteLine("Numero par");
                }
                else
                {
                    Console.WriteLine("Numero Impar");
                }
            }
            while (num != 9999);
            
        }
    }
}
