const int LIMITE_SUPERIOR = 2048;

for (int i = 1; i * i <= LIMITE_SUPERIOR; i++)
{
    int quadrado = i * i;
    Console.WriteLine($"{i}² = {quadrado}");
}

Console.WriteLine("Limite atingido! Fim.");