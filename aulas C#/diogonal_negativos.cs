using System;

namespace Programa
{
    class Programa
    {
        static void Main(string[] args)
        {
            int N,i,j,cont = 0;

            Console.Write("Qual ordem da matriz? ");
            N = int.Parse(Console.ReadLine());

            double [,] mat = new double[N,N];

            for (i = 0; i < N;i++){
                for(j = 0;j < N;j++){
                    Console.Write($"Elemento [{i},{j}]: "); 
                    mat[i, j] = double.Parse(Console.ReadLine());
                    if (mat[i,j] < 0 ){
                        cont++;    
                    }  
                } 
            }
            Console.WriteLine("DIAGONAL PRINCIPAL:");
            for (i = 0;i <N;i++){
                Console.Write(mat[i,i]+"  ");
            }
            Console.WriteLine("\nQUANTIDADE DE NEGATIVOS = "+cont);
        }
    }
}
