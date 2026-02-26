static IEnumerable<int> GerarNumeros(int n)
{
    for (int i = 1; i <= n; i++)
    {
        yield return i;
    }
}