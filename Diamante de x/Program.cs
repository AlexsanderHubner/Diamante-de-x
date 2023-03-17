using System;

namespace Diamante_de_x
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número ímpar: ");
            int num = int.Parse(Console.ReadLine());

            
            for (int i = 0; i < num; i++)
            {
                int numeroX, numeroEspaco;
                if (i <= num / 2)
                {
                    numeroX = 2 * i + 1;
                    numeroEspaco = (num - 1 - numeroX) / 2;
                }
                else
                {
                    numeroX = 2 * (num - i) - 1;
                    numeroEspaco = (num - 1 - numeroX) / 2;
                }
                for (int j = 0; j < numeroEspaco; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < numeroX; j++)
                {
                    Console.Write("x");
                }
                for (int j = 0; j < numeroEspaco; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}



