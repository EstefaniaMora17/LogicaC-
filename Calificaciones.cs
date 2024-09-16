using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientadaObjetos
{
    public class Calificaciones
    {
        public void Notas()
        {
            int NumEstudiantes = 5;
            int NumNotas = 3;
            float[,] notas = new float[NumEstudiantes, NumNotas];
            float[] promedio = new float[NumEstudiantes];

            for (int i = 0; i < NumEstudiantes; i++)
            {
                float contador = 0;
                Console.WriteLine("Estudiante Numero " + (i + 1));
                for (int j = 0; j < NumNotas; j++)
                {
                    Console.WriteLine("Ingrese Nota  "+ (j+1));
                    notas[i,j] = float.Parse(Console.ReadLine());


                    contador += notas[i, j];
                    
                }
                promedio[i] = contador / NumNotas;
                Console.WriteLine(promedio[i]);
            }

         
        }
    }
}
