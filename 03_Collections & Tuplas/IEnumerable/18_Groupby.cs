IEnumerable<int> ints = Enumerable.Range(0, 11);

var grupos = ints.GroupBy(n => n % 2 == 0);
int i = 0;

foreach (var grupo in grupos)
{
    Console.WriteLine($"Grupo {++i}");
    
    foreach (var item in grupo)
    {
        Console.WriteLine($"  - {item}");
    }
}