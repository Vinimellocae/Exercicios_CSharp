IEnumerable<int> Contar(int atual, int max)
{
    if(atual > max) yield break;

    yield return atual;

    foreach(var n in Contar(atual + 1, max))
    {
        yield return n;
    }
}

foreach(var n in Contar(0, 5))
{
    Console.WriteLine(n);
}