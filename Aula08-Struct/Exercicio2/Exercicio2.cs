using System;
struct produto
{
   public string nome;
   public int codigo;
   public int preco;
   public int quantidade;
}
class Program
{
    static void Main()
    {
        produto[] produtos = new produto[3];
        for (int i = 0; i < produtos.Length; i++)
        {
            Console.WriteLine("Digite o nome do produto:");
            produtos[i].nome = Console.ReadLine();
            Console.WriteLine("Digite o código do produto:");
            produtos[i].codigo = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o preço do produto:");
            produtos[i].preco = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade em estoque:");
            produtos[i].quantidade = int.Parse(Console.ReadLine());
        }
        int valorTotalEstoque = 0;
        for (int i = 0; i < produtos.Length; i++)
        {
            valorTotalEstoque += produtos[i].preco * produtos[i].quantidade;
        }
        Console.WriteLine($"Valor total em estoque: R$ {valorTotalEstoque:F2}");
    }
}
        