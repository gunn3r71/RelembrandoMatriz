using System;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {

            #region matriz
            int length = 5;
            int[,] matriz = new int[length, length];
            for (int l = 0; l < length; l++)
            {
                for (int c = 0; c < length; c++)
                {
                    Console.Write($"Digite o valor da linha {l}, coluna {c}");
                    matriz[l,c] = int.Parse(Console.ReadLine());
                }
            }

            foreach (int numero in matriz)
            {
                Console.WriteLine(numero);
            }
            #endregion
            Console.ReadKey();
        }
    }
}
