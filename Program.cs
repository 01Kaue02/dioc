using Exemplo.Models;
namespace Exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa();
            pessoa1.Nome = "João";
            pessoa1.Idade = 30;
            pessoa1.Apresentar();
        }
    }
}