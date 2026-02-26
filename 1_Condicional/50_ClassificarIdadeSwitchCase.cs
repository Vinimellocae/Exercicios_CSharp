// Classifique idade em faixas etárias com switch case

Console.WriteLine("Escreva sua idade");
int idade = int.Parse(Console.ReadLine());


switch (idade)
{
    case int n when (n >= 0 && n <= 12):
        Console.WriteLine("Criança");
        break;

    case int n when (n >= 13 && n <= 17):
        Console.WriteLine("Adolescente");
        break;

    case int n when (n >= 18 && n <= 60):
        Console.WriteLine("Adulto");
        break;

    case int n when (n >= 61 && n <= 115):
        Console.WriteLine("idoso");
        break;

    default:
        Console.WriteLine("Idade inválida");
        break;
}