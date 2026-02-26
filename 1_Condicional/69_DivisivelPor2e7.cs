// Receba número e verifique se é divisível por 2 e 7

Console.WriteLine("Digite um número");
int numero = int.Parse(Console.ReadLine());

bool divisivel = numero % 2 == 0 && numero % 7 == 0;

if(divisivel) {
    Console.WriteLine($"{numero} é divisivel por 2 e 7");
} else
{
    Console.WriteLine($"{numero} NÃO é divisivel por 2 e 7");
}