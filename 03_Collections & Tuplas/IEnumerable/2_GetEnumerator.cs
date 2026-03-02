IEnumerable<int> numeros = Enumerable.Range(1,10);

var enumerator = numeros.GetEnumerator();

while(enumerator.MoveNext())
{
    var item = enumerator.Current;
    Console.WriteLine(item);
}
