// yield return gera a sequência sem precisar criar uma lista em memória

static IEnumerable<int> GerarNumeros(int n)
{
    for(int i = 1; i <= n; i++)
    {
        yield return i;
    }
}

foreach(var numero in GerarNumeros(10))
{
    Console.WriteLine(numero);
}