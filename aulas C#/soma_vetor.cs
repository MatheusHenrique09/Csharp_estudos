using System;

namespace Programa
{
    class Programa
    {
        static void Main(string[] args)
        {
            int N, i, soma = 0; 
            double media;

            Console.Write("Quantos numeros vai digitar? ");
            N = int.Parse(Console.ReadLine());

            double[] mat = new double[N];

            for (i = 0; i < N; i++)
            {
                Console.Write("Digite um numero: ");
                mat[i] = double.Parse(Console.ReadLine());
            }

            Console.Write("VALORES = ");
            for (i = 0; i < N; i++)
            {
                Console.Write(mat[i] + " ");
                soma += (int)mat[i]; 
            }
            media = (double)soma / N; 
            Console.WriteLine("\nSOMA = " + soma);
            Console.WriteLine("MEDIA = " + media);
        }
    }
}
