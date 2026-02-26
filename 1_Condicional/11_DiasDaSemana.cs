// Dizer a ordem dos da semana

Console.WriteLine("Digite algum dia da semana!");
string diaDaSemana = Console.ReadLine().ToLower();

switch(diaDaSemana)
{
    case "domingo":
        Console.WriteLine("Primeiro dia da semana!");
        break;
    case "segunda":
        Console.WriteLine("Segundo dia da semana!");
        break;
    case "terça":
        Console.WriteLine("Terceiro dia da semana!");
        break;
    case "quarta":
        Console.WriteLine("Quarto dia da semana!");
        break;
    case "quinta":
        Console.WriteLine("Quinto dia da semana!");
        break;
    case "sexta":
        Console.WriteLine("Sexto dia da semana!");
        break;
    case "sábado":
        Console.WriteLine("Sétimo dia da semana!");
        break;
    default:
        Console.WriteLine("Erro! Digite um dia válido!");
        break;
}
