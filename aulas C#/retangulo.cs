using System;

namespace Programa
{
    class Programa
    {
        static void Main(string[] args){

            double Base,altura,area,perimetro,diagonal;

            Console.Write("Base do rentagulo: ");
            Base = double.Parse(Console.ReadLine());
            Console.Write("Altura do retangulo: ");
            altura = double.Parse(Console.ReadLine());

            area = Base  * altura;
            perimetro = (Base + altura) * 2;
            diagonal = Math.Sqrt(Math.Pow(Base,2.0)+Math.Pow(altura,2.0));

            Console.WriteLine("AREA DO RETANGULO: "+area.ToString("F4"));
            Console.WriteLine("PERIMETRO = "+perimetro.ToString("F4"));
            Console.WriteLine("DIAGONAL = "+diagonal.ToString("F4"));
        }
    }
}