using System.Diagnostics;
using System.Linq;

var Dict = new Dictionary<int, int>(1_000_000);

for (int i = 0; i < 1_000_000; i++)
{
    Dict.Add(i, i);
}

long Soma = 0;
var Sw = new Stopwatch();

Sw.Start();

foreach (var item in Dict)
{
    Soma += item.Value;
}

Sw.Stop();
Console.WriteLine($"Foreach: {Sw.ElapsedMilliseconds} ms");

Sw.Restart();

long SomaLinq = Dict.Sum(n => (long)n.Value);

Sw.Stop();
Console.WriteLine($"Linq Sum: {Sw.ElapsedMilliseconds} ms");