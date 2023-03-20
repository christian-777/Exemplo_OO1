using Exemplo_OO1;

internal class Program
{
    private static void Main(string[] args)
    {
        Pessoa pessoa = new Pessoa();

        pessoa = new Pessoa("jose");
        //pessoa.setNome("chris");
        Console.WriteLine(pessoa.getNome());
    }
}