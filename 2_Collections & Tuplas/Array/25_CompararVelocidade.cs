using System.Diagnostics;

int tamanho = 1_000_000;
int[] array = new int[tamanho];

for (int i = 0; i < tamanho; i++)
    array[i] = i;

// FOR
Stopwatch swFor = Stopwatch.StartNew();
long somaFor = 0;

for (int i = 0; i < array.Length; i++)
{
    somaFor += array[i];
}

swFor.Stop();

// FOREACH
Stopwatch swForeach = Stopwatch.StartNew();
long somaForeach = 0;

foreach (int n in array)
{
    somaForeach += n;
}

swForeach.Stop();

Console.WriteLine($"For: {swFor.ElapsedMilliseconds} ms");
Console.WriteLine($"Foreach: {swForeach.ElapsedMilliseconds} ms");
