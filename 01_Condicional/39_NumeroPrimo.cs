// Verificar se um número é primo

Console.WriteLine("Digite um número");
int numero = int.Parse(Console.ReadLine());

if(numero < 2)
{
    Console.WriteLine($"O {numero} não é primo");
    return;
}

for(int i = 2; i <= Math.Sqrt(numero); i++)
{
    if(numero % i == 0)
    {
        Console.WriteLine($"O {numero} não é primo");
        return;
    }
}

Console.WriteLine($"O numero {numero} é primo");