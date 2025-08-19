using Ex.Models;
namespace Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Nome = "João";
            pessoa.Idade = 30;
            pessoa.Apresentar();
        }
    }
}