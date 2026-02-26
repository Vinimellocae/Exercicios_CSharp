const int MAX_TENTATIVAS = 5;
int tentativas = 1, pensando = 52;

while (tentativas <= MAX_TENTATIVAS)
{
    Console.WriteLine($"Tentativa {tentativas}");
    Console.WriteLine("Tente adivinhar o número que estou pensando! É entre 0 e 100");
    int chute = int.Parse(Console.ReadLine());

    if (chute == pensando)
    {
        Console.WriteLine("Você acertou!");
        return;
    }

    tentativas++;
}

Console.WriteLine("Número de tentativas excedido!");