static IEnumerable<int> GerarNumeros(int n)
{
    for (int i = 1; i <= n; i++)
    {
        yield return i;
    }
}

static void MostrarPreguica()
{
    var numeros = GerarNumeros(20);

    var pares = numeros.Where(n => n % 2 == 0);

    Console.WriteLine("Antes de iterar, nada foi executado.");

    foreach (var item in pares)
    {
        Console.WriteLine(item);
    }
}

MostrarPreguica();