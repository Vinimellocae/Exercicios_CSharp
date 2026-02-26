IEnumerable<int> numeros = Enumerable.Range(1, 15);

foreach(var n in numeros)
{
    Console.WriteLine(n);
}

List<int> Lista = numeros.ToList();

foreach(var n in Lista)
{
    Console.WriteLine(n);
}