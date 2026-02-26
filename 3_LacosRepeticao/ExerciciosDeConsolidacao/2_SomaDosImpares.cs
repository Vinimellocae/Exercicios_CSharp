int soma = 0;

for (int i = 0; i <= 500; i++)
{
    bool ehhImpar = i % 2 == 1;
    if (ehhImpar)
    {
        soma += i;
    }
}

Console.WriteLine(soma);