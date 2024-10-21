using System;

namespace Programa
{
    class Programa
    {
        static void Main(string[] args)
        {
            int hora;
            
            Console.Write("Digite a hora do dia: ");
            hora = int.Parse(Console.ReadLine());
            
            if(hora < 12 ){
                Console.Write("Bom dia!");
            }
            else{
                Console.Write("Boa tarde!");
            }
        }
    }
}
