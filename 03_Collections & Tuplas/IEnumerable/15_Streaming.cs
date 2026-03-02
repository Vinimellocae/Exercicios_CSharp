bool Parar = false;

IEnumerable<int> GerarNumeros()
{
    int i = 0;

    while(!Parar)
    {
        yield return i++;
    }
}

foreach(var n in GerarNumeros())
{
    Console.WriteLine(n);

    if(n == 8)
    {
        Parar = true;
    } 
}
