using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientadaObjetos
{
    public class Rectangulo
    {

        public void PerimetroArea()
        {
            int area, parimetro;
            int lado = 6;
            int ancho = 4;

            parimetro = lado + lado + ancho + ancho;
            area = lado * ancho;

            Console.WriteLine("El parimetro del rectandulo es igual a " + parimetro + "m");
            Console.WriteLine("El Area del rectandulo es igual a " + area + "m");
        }
    }
}
