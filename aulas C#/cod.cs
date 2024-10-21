using System;
using System.Globalization;

public class Class1
{
    public static void Main(string[] args)
    {
        CultureInfo CI = CultureInfo.InvariantCulture;

        double salario1, salario2;
        string nome1, nome2; 
        int idade;
        char sexo;

        Console.Write("Digite o nome da primeira pessoa: ");
        nome1 = Console.ReadLine();
        Console.Write("Digite o salario da primeira pessoa: ");
        salario1 = double.Parse(Console.ReadLine(), CI); 

        Console.Write("Digite o nome da segunda pessoa: ");
        nome2 = Console.ReadLine();
        Console.Write("Digite o salario da segunda pessoa: ");
        salario2 = double.Parse(Console.ReadLine(), CI); 

        Console.Write("Digite uma idade: ");
        idade = int.Parse(Console.ReadLine());

        Console.Write("Digite o sexo (M/F): ");
        sexo = char.Parse(Console.ReadLine());

        Console.WriteLine($"Pessoa 1: Nome: {nome1}, Salário: {salario1}, Idade: {idade}, Sexo: {sexo}");
        Console.WriteLine($"Pessoa 2: Nome: {nome2}, Salário: {salario2}, Idade: {idade}, Sexo: {sexo}");
    }
}
