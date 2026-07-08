using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<string> nomes = new List<string>();
        
            Console.Write($"Digite a quantidade de nomes: ");
           int numNomes = int.Parse(Console.ReadLine());

        for (int i = 1; i <= numNomes; i++)
        {
            Console.Write($"Digite o {i}º nome: ");
            nomes.Add(Console.ReadLine());
        }

               Dictionary<int, Queue<string>> grupos = new Dictionary<int, Queue<string>>();

        foreach (string nome in nomes)
        {
            int tamanho = nome.Length;

            if (!grupos.ContainsKey(tamanho))
                grupos[tamanho] = new Queue<string>();

            grupos[tamanho].Enqueue(nome);
        }

        List<int> tamanhos = grupos.Keys.OrderBy(t => t).ToList();

        while (grupos.Any(g => g.Value.Count > 0))
        {
            foreach (int tamanho in tamanhos)
            {
                if (grupos[tamanho].Count > 0)
                {
                    Console.Write(grupos[tamanho].Dequeue() + " ");
                }
            }

            Console.WriteLine();
        }
    }
}