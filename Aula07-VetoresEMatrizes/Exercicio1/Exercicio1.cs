using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[10];
        int[] pares = new int[10];
        int[] impares = new int[10];

        Console.WriteLine("Digite 10 números:");

        for (int i = 0; i < 10; i++)
        {
            numeros[i] = int.Parse(Console.ReadLine());
        }

        int parIndex = 0;
        int imparIndex = 0;

        for (int i = 0; i < 10; i++)
        {
            if (numeros[i] % 2 == 0)
            {
                pares[parIndex] = numeros[i];
                parIndex++;
            }
            else
            {
                impares[imparIndex] = numeros[i];
                imparIndex++;
            }
        }

        Console.WriteLine("\nNúmeros pares:");
        for (int i = 0; i < parIndex; i++)
        {
            Console.WriteLine(pares[i]);
        }

        Console.WriteLine("\nNúmeros ímpares:");
        for (int i = 0; i < imparIndex; i++)
        {
            Console.WriteLine(impares[i]);
        }
    }
}