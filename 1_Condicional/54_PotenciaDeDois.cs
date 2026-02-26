// Verifique se um número é potência de 2

Console.WriteLine("Digite um número");
int numero = int.Parse(Console.ReadLine());
int n = numero;


bool ehPotenciaDe2 = Math.Log2(n) % 1 == 0;

if (ehPotenciaDe2)
{
    Console.WriteLine($"{numero} é potencia de 2");
}
else
{
    Console.WriteLine($"{numero} NÃO é potencia de 2");
}