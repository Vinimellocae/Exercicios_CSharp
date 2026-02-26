static int CalcularFatorial(int N) {
    
    int Mult = 1;
    int i = 1;

    while(i <= N)
    {
        Mult *= i;
        i++;    
    }

    return Mult;
}

Console.WriteLine(CalcularFatorial(6));
