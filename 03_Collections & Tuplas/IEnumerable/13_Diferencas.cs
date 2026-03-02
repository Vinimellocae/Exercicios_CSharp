var numeros = Enumerable.Range(1, 20).Select(n =>
{
    Console.WriteLine($"Processando {n}");
    return n * 2;
});

foreach (var n in numeros)
{
    Console.WriteLine(n);
}

var numeros2 = Enumerable.Range(1, 20)
    .Select(n =>
    {
        Console.WriteLine($"Processando {n}");
        return n * 2;
    }).ToList();
