// Verificar se a soma é maior do que 100

Console.WriteLine("Digite o primeiro numero");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo numero");
int num2 = int.Parse(Console.ReadLine());

bool maiorQueCem = (num2 + num1) > 100;

if(maiorQueCem)
{
    Console.WriteLine("A soma é maior que 100");    
} else
{
    Console.WriteLine("A soma NÃO é maior que 100");
}