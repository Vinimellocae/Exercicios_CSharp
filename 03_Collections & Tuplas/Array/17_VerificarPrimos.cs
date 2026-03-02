bool ehPrimo(int N)
{
    if(N <= 1) return false; 

    for(int i = 2; i <= Math.Sqrt(N); i++)
    {
        if(N % i == 0) return false;
    }
    return true;
}

int[] ints = {5, 7, 14, 32, 6};

bool TemPrimosNoArray = ints.Any(N => ehPrimo(N));

if(TemPrimosNoArray)
{
    Console.WriteLine("Há numeros Primos no array!");
}
else
{
    Console.WriteLine("Não há numeros Primos no array!");
    Console.WriteLine(string.Join(", ", ints));
}