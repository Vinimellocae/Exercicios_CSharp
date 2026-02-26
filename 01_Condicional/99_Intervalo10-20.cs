// Receba número e verifique se está no intervalo aberto [10, 20].

Console.WriteLine("Digite um número");
int numero = int.Parse(Console.ReadLine());

bool intervalo = numero > 10 && numero < 20;

if(intervalo)
{
    Console.WriteLine($"O número {numero} está dentro do intevalo");
} else
{
    Console.WriteLine($"O número {numero} está fora do intevalo");
}