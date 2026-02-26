// Receba um número e classifique como baixo, médio ou alto.

Console.WriteLine("Digite um número");
int numero = int.Parse(Console.ReadLine());

bool alto = numero > 100;
bool baixo = numero < 40;

if(alto)
{
    Console.WriteLine($"O número {numero} é Alto!");
}
else if(baixo)
{
    Console.WriteLine($"O número {numero} é Baixo");
} else
{
    Console.WriteLine($"O número {numero} é Médio");
}