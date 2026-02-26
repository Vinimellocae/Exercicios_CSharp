// Verificar se o primeiro número é divisivel pelo segundo

Console.WriteLine("Digite o primeiro numero");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo numero");
int num2 = int.Parse(Console.ReadLine());

if(num1 % num2 == 0)
{
    Console.WriteLine("É divisivel");
} else
{
    Console.WriteLine("NÃO é divisivel");
}