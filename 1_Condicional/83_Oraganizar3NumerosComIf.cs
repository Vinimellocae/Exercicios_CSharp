// Receba três números e ordene-os (usando if).

Console.WriteLine("Digite o primeiro numero");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo numero");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o terceiro numero");
int c = int.Parse(Console.ReadLine());

int maior;
int menor;
int meio;

if (a >= b && a >= c)
{
    maior = a;

    if (b >= c)
    {
        meio = b;
        menor = c;
    }
    else
    {
        meio = c;
        menor = b;
    }
}
else if (b >= a && b >= c)
{
    maior = b;

    if (a >= c)
    {
        meio = a;
        menor = c;
    }
    else
    {
        meio = c;
        menor = a;
    }
}
else
{
    maior = c;

    if (a >= b)
    {
        meio = a;
        menor = b;
    }
    else
    {
        meio = b;
        menor = a;
    }
}

Console.WriteLine($"{maior}, {meio}, {menor}");