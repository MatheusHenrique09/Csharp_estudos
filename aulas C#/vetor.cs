using System;

namespace Programa
{
    class Programa
    {
        static void Main(string[] args)
        {
            int N;
            Console.Write("Quantos numeros voce vai digitar: ");
            N = int.Parse(Console.ReadLine());

            double[] vet = new double[N];

            for (int i = 0; i < N; i++){
                Console.Write("Digite um numero: ");
                vet[i] = double.Parse(Console.ReadLine());   
            }

            Console.WriteLine("Numeros digitados: ");
            for (int i = 0; i < N; i++){
                Console.WriteLine(vet[i].ToString("F1"));   
            }

        }
    }
}

