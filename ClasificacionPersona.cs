using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientadaObjetos
{
    public class ClasificacionPersona
    {

        string[] nombre;
        int[] edad;
        int[] sexo ;
        float[] sueldo ;
        int numHombrePobre = 0, numMujerRica = 0, numJovenClaseMedia = 0;

        public void Persona(int NumPersonas)
        {
            nombre = new string[NumPersonas];
            edad = new int[NumPersonas];
            sexo = new int[NumPersonas];
            sueldo = new float[NumPersonas];
      
            

            for (int i = 0; i < NumPersonas; i++)
            {
                Console.WriteLine("\n");
                Console.WriteLine("ingresa Nombre ");
                nombre[i] = Console.ReadLine();
                Console.WriteLine("\n");
                Console.WriteLine("ingresa Edad");
                edad[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("\n");
                Console.WriteLine("ingresa Sexo 1 : Hombre /  2 : Mujer");
                sexo[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("\n");
                Console.WriteLine("ingresa sueldo");
                sueldo[i] = float.Parse(Console.ReadLine());
                Console.WriteLine("\n");

                Console.WriteLine(Validacion(i));

            }
          
        }

        public string Validacion(int i)
        {

           
            if (sexo[i] == 1 && sueldo[i] < 500)
            {
                numHombrePobre++;
                return "\n ---Hombre Pobre---";

            }
            else if (sexo[i] == 2 && sueldo[i] > 600)
            {
                numMujerRica++;
                return "\n ---Mujer Rica---";
                
            }
            else if(sexo[i] == 2 && edad[i] >=20 && edad[i] <= 30 && sueldo[i] >= 1200 && sueldo[i] <= 2000)
            {
                numJovenClaseMedia++;
                return "\n ----Joven mujer de clase media----";
                 
            }

            return "\n ----no estas en ninguna de estas categoria---";
            
        }
        
        public void contadores()
        {
            Console.WriteLine(" \n --- TOTALIDAD ---");
            Console.WriteLine("\n Hombres pobres :"+" "+ numHombrePobre);
            Console.WriteLine("\n Mujer rica     :" + " "+numMujerRica);
            Console.WriteLine("\n Joven mujer de clase media : "+" " + numJovenClaseMedia);

        }


    }
}

