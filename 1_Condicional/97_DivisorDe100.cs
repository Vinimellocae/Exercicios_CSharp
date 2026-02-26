//  Receba número e verifique se é divisor de 100

Console.WriteLine("Digite um número");
int numero = int.Parse(Console.ReadLine());

if(numero == 0)
{
    Console.WriteLine("Impossível dividir por Zero!");
    return;
}

bool divisorDe100 = 100 % numero == 0;

if(divisorDe100)
{
    Console.WriteLine($"{numero} é divisor de 100");
} else
{
    Console.WriteLine($"{numero} NÃO é divisor de 100");
}