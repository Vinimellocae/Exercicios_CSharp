List<int> numeros = new List<int> {11, 46, 93, -1, -2, -6, 3};

foreach(var N in numeros)
{
    if(N < 0)
    {
        Console.WriteLine("Há números negativos na lista");
        return;
    }
}
        
Console.WriteLine("Não há números negativos na lista");