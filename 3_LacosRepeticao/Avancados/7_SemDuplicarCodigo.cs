int LerEntrada()
{
    Console.WriteLine("Digite um numero: ");
    return int.Parse(Console.ReadLine());
}

int n;

do
{
    n = LerEntrada();
}
while(n != 0);

Console.WriteLine("Eu estava pensando exatamente neste número!");