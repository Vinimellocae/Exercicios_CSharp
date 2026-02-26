// Verificar se o número está dentro da faixa estabelecida

Console.WriteLine("Digite um número de 0 a 10");
int numero = int.Parse(Console.ReadLine());

bool dentroDaFaixa = numero >=7 && numero <=10;
bool numeroInvalido = numero > 10 || numero < 0;

if(numeroInvalido)
{
    Console.WriteLine($"Número inválido!");
    return;
}

if(dentroDaFaixa)
{
    Console.WriteLine($"O número {numero} está dentro da faixa! :D ");
} else
{
    Console.WriteLine($"O número {numero} NÃO está dentro da faixa :( ");
}
