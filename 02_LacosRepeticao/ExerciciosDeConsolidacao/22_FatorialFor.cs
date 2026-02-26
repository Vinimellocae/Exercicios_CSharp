static int CalcularFatorial(int N)
{

    int Mult = 1;

    for (int i = N; i >= 1; i--)
    {
        Mult = Mult * i;
    }

    return Mult;
}

Console.WriteLine(CalcularFatorial(5));