Random rnd  = new Random();

Console.WriteLine("Adivinhar número!");

int Pensando = rnd.Next(1, 11);

while(true)
{
    Console.WriteLine("Adivinhe que número de 1 a 10 eu estou pensando!");
    
    if (!int.TryParse(Console.ReadLine(), out int chute))
    {
        Console.WriteLine("Entrada inválida. Digite um número.");
        continue;
    }

    if(chute > Pensando)
    {
        Console.WriteLine("O número é maior!");
    }
    else if(chute < Pensando)
    {
        Console.WriteLine("O número é maior!");
    }

    
    if(Pensando == chute) break;;
}

Console.WriteLine("Você acertou!");