// Receba número e mostre se é perfeito (soma dos divisores = número).

Console.WriteLine("Digite seu número");
int numero = int.Parse(Console.ReadLine());
int soma = 0;

if(numero <= 0)
{
    Console.WriteLine("Número inválido");
    return;
}

for(int i = 1; i <= numero/2; i++)
{
    if(numero % i == 0)
    {
        soma += i;
    }
} 

bool numeroPerfeito = soma == numero;

Console.WriteLine(numeroPerfeito ? $"O número {numero} é perfeito" : $"O número {numero} NÃO é perfeito" );
