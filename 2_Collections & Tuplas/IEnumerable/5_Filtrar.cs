IEnumerable<int> Numeros = Enumerable.Range(1, 25);

var DivisiveisPor5 = Numeros.Where(n => n % 5 == 0);

foreach(var num in DivisiveisPor5)
{
    Console.WriteLine(num);
}