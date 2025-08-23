using Exemplo.Models;

int quantidade = 10;
int compra = 1;
bool podeComprar = quantidade >= compra;

Console.WriteLine($"Você tem {quantidade} itens em estoque.");
Console.WriteLine($"Você quer comprar {compra} itens.");
Console.WriteLine($"Pode comprar? {podeComprar}");
if (compra == 0)
{
    Console.WriteLine("Estoque esgotado!");
}
else
if (podeComprar )
{
    Console.WriteLine("Você pode comprar!");
}
else
{
    Console.WriteLine("Você não pode comprar!");
}