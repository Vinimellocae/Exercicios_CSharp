// Receba um número decimal e classifique como inteiro ou não.

Console.WriteLine("Digite um numero decimal ou inteiro");
float numero = float.Parse(Console.ReadLine());

bool ehInteiro = numero % 1 == 0;

if(ehInteiro)
{
    Console.WriteLine("O Número é Inteiro");
} else
{
    Console.WriteLine("O Número é Decimal");
}
