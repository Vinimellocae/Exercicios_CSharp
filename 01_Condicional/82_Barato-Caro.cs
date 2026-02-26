//  Receba valor e classifique como caro ou barato com base em limite.

Console.WriteLine("Digite o preço de algum objeto");
double preco = double.Parse(Console.ReadLine());

int limite = 200;

if(preco <= 0)
{
    Console.WriteLine("Preço inválido");
}

bool caro = preco > limite;


if(caro)
{
    Console.WriteLine("O produto é caro");
} 
else
{
    Console.WriteLine("O produto é barato");
}