using Exemplo.Models;
int quantidade = 10;

int coompra = 11;
bool podeComprar = quantidade >= coompra;
Console.WriteLine($"Você tem {quantidade} itens em estoque.");
Console.WriteLine($"Você quer comprar {coompra} itens.");
Console.WriteLine($"Pode comprar? {podeComprar}");

if (podeComprar )
{
    Console.WriteLine("Você pode comprar!");
}
else
{
    Console.WriteLine("Você não pode comprar!");
}