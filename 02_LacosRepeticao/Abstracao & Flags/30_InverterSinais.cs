List<int> Numeros = new List<int> {15, -43, 87, 91, -52, -2, 124, 41};

Numeros.ForEach(n =>
{
    n = n * (-1);
    Console.WriteLine(n);
});