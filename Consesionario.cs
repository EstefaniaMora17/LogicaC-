using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OrientadaObjetos
{
    public class Consesionario
    {
        public void vehiculos()
        {
            Console.WriteLine(" --- Modelo De Vehiculos ---");
            Console.WriteLine(" 1) Cutlass  Precio: 120'000'000 Descuento: 8%");
            Console.WriteLine(" 2) Cavalier Precio: 48'000'000 Descuento: 5%");
            Console.WriteLine(" 3) Chevy Precio: 50'000'000 Descuento: 6% ");
            Console.WriteLine(" 4) Century Precio; 16'000'000 Descuento: 9%");
            Console.WriteLine("Elige una de las opciones");
            int opcion = Convert.ToInt32(Console.ReadLine());

            decimal precio, total, Descuento;


            //switch (opcion)
            //{
            //    case 1:
            //        precio = 120000000;
            //        Descuento = precio - 8% ;
            //        total = precio * Descuento;

            //        Console.WriteLine(total);

            //        break;
            //    case 2:
            //        precio = 48000000;
            //        Descuento = 5 / 100;
            //        total = precio * Descuento;
            //        Console.WriteLine(total);
            //        break;
            //    case 3:
            //        precio = 50000000;
            //        Descuento = 6 / 100;
            //        total = precio * Descuento;
            //        Console.WriteLine(total);
            //        break;
            //    case 4:
            //        precio = 16000000;
            //        Descuento = 9 / 100;
            //        total = precio * Descuento;
            //        Console.WriteLine(total);
            //        break;
            //    default:
            //        Console.WriteLine("El modelo no es valido");
            //        break;



        }
    }
}
