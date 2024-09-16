using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientadaObjetos
{
    public class AumentarDisminuir
    {
        public void numerosAumDism()
        {
            int inicio= 1, final = 99;

            for (int i = inicio; i <= final; i++)
            {
                Console.Write(i);
                Console.Write("-");
                Console.WriteLine(final - (i - inicio));
            }
        }
    }
}
