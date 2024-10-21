using System;

namespace Programa
{
    class Programa
    {
        static void Main(string[] args)
        {
            int N, i; 
            double soma = 0;
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
                Console.Write(mat[i].ToString("F2") + " ");
                soma += mat[i]; 
            }
            media = soma / N; 
            Console.WriteLine("\nSOMA = " + soma.ToString("F2"));
            Console.WriteLine("MEDIA = " + media.ToString("F2"));
        }
    }
}
