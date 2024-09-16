using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientadaObjetos
{
    public class Bucles
    {
        public void ciclo1()
        {
            int i = 0;
            int j = 0;  
            
            while (i < 3)
            {
                while (j < 3)
                {
                    Console.WriteLine(i+"-"+j);
                    j ++;

                }
                i++;
                j = 0;
            }
        }
        public void ciclo2()
        {
            int i = 0, j = 0, k = 0;

            while (i < 3)
            {
                while (j < 3)
                {
                    while (k < 3)
                    {
                        Console.WriteLine(i + "-" + j + "-" + k);
                        j++;
                        k++;

                    }
                    k = 0;
                }
                i++;
                j = 0;
            }
        }
        public void ciclo3()
        {
            int n = 5;         
            while (n > 0)
            {
                n -= 1;
                Console.WriteLine(n);
            }
        }
    }
}
