using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientadaObjetos
{
    public class NumerosAlCubo
    {
        public void numeroNaturalesAlCubo()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i+"   "+Math.Pow(i,3));
            }
        
        }
    }
}
