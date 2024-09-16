using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientadaObjetos
{
    public class NumerosAlCuadrado
    {
        public void numeroEnteros()
        {
            double num1, num2;
            string comparacion;

            Console.WriteLine("ingrese numero 1");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese numero 2");
            num2 = double.Parse(Console.ReadLine());

            num1 = Math.Pow(num1, 2);

            if (num2 == num1)
            {
                Console.WriteLine("El segundo es el cuadrado exacto del primero.");
            }
            else if (num2 < num1)
            {
                Console.WriteLine("El segundo es menor que el cuadrado del primero.");
            }
            else
            {
                Console.WriteLine("El segundo es mayor que el cuadrado del primero.");
            }
        }
    }
}
