using System.Diagnostics;

IEnumerable<int> enumeravel = Enumerable.Range(1, 10_000_000);

List<int> Lista = enumeravel.ToList();

Stopwatch sw = new Stopwatch();
long soma = 0;

sw.Start();

foreach (var n in enumeravel)
{
    soma += n;
}

sw.Stop();
Console.WriteLine($"Enumerable: {sw.ElapsedMilliseconds}ms");
soma = 0;
sw.Restart();

for (int i = 0; i < Lista.Count; i++)
{
    soma += Lista[i];
}
sw.Stop();
Console.WriteLine($"Lista: {sw.ElapsedMilliseconds}ms");