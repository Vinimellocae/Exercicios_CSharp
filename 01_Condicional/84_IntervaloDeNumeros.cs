// Verifique se um número está entre dois valores.

Console.WriteLine("Digite um número");
int numero = int.Parse(Console.ReadLine());

bool intervalo = numero > 80 && numero < 160;

if(intervalo)
{
    Console.WriteLine($"O número {numero} está dentro do intevalo");
}
else
{
    Console.WriteLine($"O número {numero} está fora do intevalo");
}