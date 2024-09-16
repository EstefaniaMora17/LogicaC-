using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientadaObjetos
{
    public class Cajero
    {
        public decimal dinero;
        public decimal valor = 0;
        public void CajeroAutomatico()
        {
            Console.WriteLine(" --- Cajero ---");
            Console.WriteLine(" 1) Ingresar Dinero");
            Console.WriteLine(" 2) Retirar Dinero");
            Console.WriteLine(" 3) Ver saldo ");
            Console.WriteLine(" 4) Consignar");
            Console.WriteLine(" 5) Salir ");
            Console.WriteLine("Elige una de las opciones");
            int opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    IngresarDinero();
                    break;
                case 2:
                    retirarDinero();
                    break;
                case 3:
                    VerSaldo();
                    break;
                case 4:
                    consignar();
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
            }
        }
        public void IngresarDinero()
        {
            Console.WriteLine("Ingrese el valor ");
            dinero = decimal.Parse(Console.ReadLine());

            valor += dinero;

            Console.WriteLine(" --- Tu dinero fue ingresado exitosamente --- ");
            Console.WriteLine("\n");
            CajeroAutomatico();
        }
        public void retirarDinero()
        {
            Console.WriteLine("Ingrese el valor a retirar");
            dinero = decimal.Parse(Console.ReadLine());

            valor -= dinero;

            Console.WriteLine(" --- Tu Retiro fue realizado exitosamente --- ");

            Console.WriteLine("\n");

            CajeroAutomatico();
        }
        public void VerSaldo()
        {
            Console.WriteLine(valor);
            CajeroAutomatico();

        }
        public void consignar()
        {
            Console.WriteLine("Ingrese el valor a retirar");
            dinero = decimal.Parse(Console.ReadLine());
            
            valor -= dinero;

            Console.WriteLine(" --- Tu Consigancion fue realizada exitosamente --- ");
            Console.WriteLine("\n");

            CajeroAutomatico();
        }
    }
}