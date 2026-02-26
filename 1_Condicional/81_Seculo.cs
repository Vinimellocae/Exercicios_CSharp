// Receba ano e verifique se é do século XX ou XXI.

Console.WriteLine("Digite um ano");
int ano = int.Parse(Console.ReadLine());

bool XX = ano >= 1901 && ano <= 2000;
bool XXI = ano >= 2001 && ano <= 2100;

if(XX)
{
    Console.WriteLine($"{ano} pertence ao século XX");
} 
else if (XXI) 
{
    Console.WriteLine($"{ano} pertence ao século XXI");
} 
else
{
    Console.WriteLine($"{ano} NÃO pertence nem ao século XXI nem ao XXI");
}
