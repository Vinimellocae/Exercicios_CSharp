// Verificar se o número digitado é divisível por 5

Console.WriteLine("Digite algum número:");
int num = int.Parse(Console.ReadLine());

bool divisaoPor5 = num % 5 == 0;

if (divisaoPor5)
{
    Console.WriteLine("Divisível por 5");
}
else
{
    Console.WriteLine("NÃO é divisível por 5");
}