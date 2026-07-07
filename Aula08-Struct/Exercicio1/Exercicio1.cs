using System;
struct filme
{
   public string nome;
   public string diretor;
   public int lancamento;
   public int duracao;
}
class Program
{
    static void Main()
    {
        filme[] filmes = new filme[3];
        for (int i = 0; i < filmes.Length; i++)
        {
            Console.WriteLine("Digite o nome do filme:");
            filmes[i].nome = Console.ReadLine();
            Console.WriteLine("Digite o nome do diretor:");
            filmes[i].diretor = Console.ReadLine();
            Console.WriteLine("Digite o ano de lançamento:");
            filmes[i].lancamento = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a duração em minutos:");
            filmes[i].duracao = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Filmes cadastrados:");
        for (int i = 0; i < filmes.Length; i++)
        {
            Console.WriteLine($"Nome: {filmes[i].nome}");
            Console.WriteLine($"Diretor: {filmes[i].diretor}");
            Console.WriteLine($"Ano de lançamento: {filmes[i].lancamento}");
            Console.WriteLine($"Duração: {filmes[i].duracao} minutos");
            Console.WriteLine();
        }
        filme maisantigo = filmes[0];
        for (int i = 1; i < filmes.Length; i++)
        {
            if (filmes[i].lancamento < maisantigo.lancamento)
            {
                maisantigo = filmes[i];
            }
        }
        Console.WriteLine($"O filme mais antigo é: {maisantigo.nome}");
        Console.WriteLine($"O filme mais antigo é: {maisantigo.diretor}");
        Console.WriteLine($"O filme mais antigo é: {maisantigo.lancamento}");
        Console.WriteLine($"O filme mais antigo é: {maisantigo.duracao} minutos");
    }

}