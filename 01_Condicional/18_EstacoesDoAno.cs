// Dizer a estação do ano de acordo com o mês

Console.WriteLine("Digite algum mês");
string mes = Console.ReadLine().ToLower();

switch (mes)
{
    case "janeiro":
        Console.WriteLine("Verão!");
        break;

    case "fevereiro":
    Console.WriteLine("Verão!");
        break;
    
    case "março":
    Console.WriteLine("Outono!");
        break;
    
    case "abril":
    Console.WriteLine("Outono!");
        break;

    case "maio":
    Console.WriteLine("Outono!");
        break;

    case "junho":
    Console.WriteLine("Inverno!");
        break;

    case "julho":
    Console.WriteLine("Inverno!");
        break;

    case "agosto":
    Console.WriteLine("Inverno!");
        break;

    case "setembro":
    Console.WriteLine("Primavera!");
        break;

    case "outubro":
    Console.WriteLine("Primavera!");
        break;

    case "novembro":
    Console.WriteLine("Primavera!");
        break;

    case "dezembro":
    Console.WriteLine("Verão!");
        break;

    default:
        Console.WriteLine("Digite um mês válido!");
        break;
}