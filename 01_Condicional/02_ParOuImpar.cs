// Verificar se o número é par ou Impar

Console.WriteLine("digite um numero");
int num = int.Parse(Console.ReadLine());

bool Par = num % 2 == 0;

if(Par)
{
    Console.WriteLine("O número é Par");
}
else
{
    Console.WriteLine("O número é Impar");
}