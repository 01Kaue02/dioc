using dioc.Models;

int[] arrayInteiro = new int[3];

arrayInteiro[0] = 72;
arrayInteiro[1] = 64;
arrayInteiro[2] = 50;



for (int contador = 0; contador < arrayInteiro.Length; contador++)
{
    Console.WriteLine($"Posição N {contador}- {arrayInteiro[contador]}");
}

Console.WriteLine("Percorrendo o Array com o FOREACH");
int contadorforeach = 0;
foreach (int valor in arrayInteiro)
{
    Console.WriteLine ($"Posição N  {contadorforeach}- {valor}");
    contadorforeach++;
    
}















//int soma = 0 , numero = 0;
//
//
//do
//{
//    Console.WriteLine("Digite um número");
//    numero = Convert.ToInt32(Console.ReadLine());
//
//    soma += numero;
//} while (numero != 0);
//
//Console.WriteLine($"A soma dos números é: {soma}");















// int numero = 10;
// int contador = 0;
//
//
//le (contador < 10)
//
//
// Console.WriteLine($"{numero} x {contador} = {numero * contador}");
// contador++;
// if (contador == 6)
// {
//     break;
// }
//




//int numero = 10;
//
//Console.WriteLine($" {numero} x 1 = {numero * 1}");
//
//for (int i = 1; i <= 10; i++)
//{
//    Console.WriteLine($" {numero} x {i} = {numero * i}");
//}




//Calculadora calc = new Calculadora();
//
//calc.Somar(19, 99);
//calc.Subtrair(19, 99);
//calc.Multiplicar(19, 99);
//calc.Dividir(19, 9);


//bool choveu = true;
//bool estaTarde = true;
//
//if (!choveu && !estaTarde)
//{
//    Console.WriteLine("Pode sair!");
//}
//else
//{
//    Console.WriteLine("Fique em casa!");
//}











//bool possuiPresencaMinima = false;
//double notaDoAluno = 9.0;
//
//if (possuiPresencaMinima || notaDoAluno >= 6.0)
//{
//    Console.WriteLine("Aluno aprovado!");
//}
//else
//{
//    Console.WriteLine("Aluno reprovado!");
//}














//Console.WriteLine("Digite uma letra");
//string letra = Console.ReadLine();






//switch (letra)
//{
//    case "a":
//    case "e":
//    case "i":
//    case "o":
//    case "u":
//        Console.WriteLine("É uma vogal");
//        break;
//    default:
//        Console.WriteLine("É uma consoante");
//        break;
//}



//


//int quantidade = 10;
//int compra = 1;
//bool podeComprar = quantidade >= compra;

//Console.WriteLine($"Você tem {quantidade} itens em estoque.");
//Console.WriteLine($"Você quer comprar {compra} itens.");
//Console.WriteLine($"Pode comprar? {podeComprar}");
//if (compra == 0)//
//{
   // Console.WriteLine("Estoque esgotado!");
//}
//else
//if (podeComprar )
//{
//    Console.WriteLine("Você pode comprar!");
//}
//else
//{
//    Console.WriteLine("Você não pode comprar!");
//}//