// Jokempo não interativo com switch case

Console.WriteLine("Pedra, papel, tesoura!");
string Escolha = Console.ReadLine().ToLower();

// Adversário sempre joga tesoura

switch(Escolha)
{
    case "pedra":
    Console.WriteLine("Você ganhou!");
    break;

    case "papel":
    Console.WriteLine("Você perdeu!");
    break;

    case "tesoura":
    Console.WriteLine("O jogo empatou!");
    break;

    default:
    Console.WriteLine("Escolha inválida");
    break;
}
