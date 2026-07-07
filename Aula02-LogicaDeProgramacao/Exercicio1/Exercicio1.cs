using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o num do funcionario: ");
        int num = int.Parse(Console.ReadLine());
        Console.Write("Digite a quantidade de horas trabalhadas: ");
        int horas = int.Parse(Console.ReadLine());
        Console.Write("Digite o valor por hora: ");
        double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double salario = horas * valorHora;
        Console.WriteLine($"Num = {num}");
        Console.WriteLine($"Salario = {salario.ToString("F2", CultureInfo.InvariantCulture)}");
        
    }
}