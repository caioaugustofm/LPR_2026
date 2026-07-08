
using System;
struct livro
{
   public string nome;
   public string autor;
   public int publicacao;
   public int pagina;
   public int preco;
}
class Program
{
    static void Main()
    {
        livro[] livros = new livro[3];
        for (int i = 0; i < livros.Length; i++)
        {
            Console.WriteLine("Digite o nome do livro:");
            livros[i].nome = Console.ReadLine();
            Console.WriteLine("Digite o autor do livro:");
            livros[i].autor = Console.ReadLine();
            Console.WriteLine("Digite o ano de publicação:");
            livros[i].publicacao = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número de páginas:");
            livros[i].pagina = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o preço do livro:");
            livros[i].preco = int.Parse(Console.ReadLine());
        }
        double estoque = 0;
        int mediaPagina = 0;
        for (int i = 0; i < livros.Length; i++)
        {
            estoque += livros[i].preco;
            mediaPagina += livros[i].pagina;
        }        
        mediaPagina /= livros.Length;
        Console.WriteLine($"Valor total em estoque: R$ {estoque:F2}");
        Console.WriteLine($"Média de páginas: {mediaPagina}");
    }
}     