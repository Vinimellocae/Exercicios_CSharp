Console.WriteLine("Jokenpo!");
Console.WriteLine("Tesoura = 1 : Pedra = 2 : Papel = 3");

Random rnd = new Random();

while (true)
{
    Console.WriteLine("\nDigite sua escolha:");
    int Escolha1 = int.Parse(Console.ReadLine());

    if (Escolha1 < 1 || Escolha1 > 3)
    {
        Console.WriteLine("Escolha inválida.");
        continue;
    }

    int Escolha2 = rnd.Next(1, 4);

    // vitórias jogador 1
    bool vitoria = (Escolha1 == 1 && Escolha2 == 3) ||
                   (Escolha1 == 2 && Escolha2 == 1) ||
                   (Escolha1 == 3 && Escolha2 == 2);

    // derrotas jogador 1
    bool derrota = (Escolha1 == 3 && Escolha2 == 1) ||
                   (Escolha1 == 1 && Escolha2 == 2) ||
                   (Escolha1 == 2 && Escolha2 == 3);

    string[] nomes = { "", "Tesoura", "Pedra", "Papel" };

    Console.WriteLine($"Oponente jogou {nomes[Escolha2]}");

    if (vitoria)
        Console.WriteLine("Você venceu!");
    else if (derrota)
        Console.WriteLine("Você perdeu!");
    else
        Console.WriteLine("Empate!");

    Console.WriteLine("\nPressione ENTER para jogar novamente ou digite 'n' para sair.");
    string resp = Console.ReadLine().ToLower();

    if (resp == "n")
        break;
}
