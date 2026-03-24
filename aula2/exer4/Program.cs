using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.WriteLine("Peça 1 (Código, Quantidade, Valor):");
        int cod1 = int.Parse(Console.ReadLine());
        int qnt1 = int.Parse(Console.ReadLine());
        double preco1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("Peça 2 (Código, Quantidade, Valor):");
        int cod2 = int.Parse(Console.ReadLine());
        int qnt2 = int.Parse(Console.ReadLine());
        double preco2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double total = (qnt1 * preco1) + (qnt2 * preco2);
        Console.WriteLine($"Valor total: {total.ToString("F2", CultureInfo.InvariantCulture)}");
    }
}