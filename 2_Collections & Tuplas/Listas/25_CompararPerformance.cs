using System.Diagnostics;

List<int> lista = Enumerable.Range(1, 1_000_000).ToList();
Stopwatch sw = new Stopwatch();

// for
sw.Start();
for (int i = 0; i < lista.Count; i++)
{
    int x = lista[i];
}
sw.Stop();
Console.WriteLine($"for: {sw.ElapsedMilliseconds} ms");

// foreach
sw.Restart();
foreach (var item in lista)
{
    int x = item;
}
sw.Stop();
Console.WriteLine($"foreach: {sw.ElapsedMilliseconds} ms");

// ForEach
sw.Restart();
lista.ForEach(item =>
{
    int x = item;
});
sw.Stop();
Console.WriteLine($"ForEach: {sw.ElapsedMilliseconds} ms");
