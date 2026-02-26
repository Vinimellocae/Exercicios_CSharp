// Verificar se o número digitado está entre 1 e 100

Console.WriteLine("Digite algum número!");
int num = int.Parse(Console.ReadLine());

if(num >= 1 && num <= 100)
{
    Console.WriteLine("O número está entre 1 e 100!");
} else
{
    Console.WriteLine("O número NÃO está entre 1 e 100!");
}