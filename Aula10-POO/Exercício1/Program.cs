
using System;

class Retangulo
{
    public double Altura;
    public double Largura;

    public double calArea()
    {
        return Altura * Largura;
    }

    public double calPerimetro()
    {
        return 2 * (Altura + Largura);
    }
}

class Program
{
    static void Main()
    {
        Retangulo retan = new Retangulo();

        Console.Write("Digite a altura: ");
        retan.Altura = double.Parse(Console.ReadLine());

        Console.Write("Digite a largura: ");
        retan.Largura = double.Parse(Console.ReadLine());

        Console.WriteLine("Área: " + retan.calArea());
        Console.WriteLine("Perímetro: " + retan.calPerimetro());
    }
}
