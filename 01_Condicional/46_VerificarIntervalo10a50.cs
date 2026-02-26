// Verifique se um número é dentro do intervalo [10, 50]

Console.WriteLine("Digite um númeo");
int numero = int.Parse(Console.ReadLine());

bool intervalo = numero >= 10 && numero <= 50;

if(intervalo)
{
    Console.WriteLine($"O número {numero} está entre 10 e 50");
} else
{
    Console.WriteLine($"O número {numero} NÃO está entre 10 e 50");
}