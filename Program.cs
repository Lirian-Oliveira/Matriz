using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {

            int materias ;
            float nota;
            Console.Write("Quantas matérias você tem? ");
            materias = int.Parse(Console.ReadLine());
            int[,] matriz = new int[materias, 4];

            for (int m = 0 ; m < materias; m++)
            {
                for (int u = 0; u < 4; u++)
                {
                    Console.Write("Informe  sua nota na materia "    +(m+1)+  " unidade " +(u+1)+ ": " );
                    nota = float.Parse(Console.ReadLine());
                
                }
    
            }
            Console.WriteLine("");
            Console.ReadLine();

        }
    }
}
