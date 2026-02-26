Console.WriteLine("Defina um limite: ");
int Limite = int.Parse(Console.ReadLine());

for (int i = 2; i <= Limite; i++)
{
    bool ehhPrimo = true;

    for (int j = 2; j <= Math.Sqrt(i); j++)
    {
        if (i % j == 0)
        {
            ehhPrimo = false;
            break;
        }
    }

    if (ehhPrimo) Console.WriteLine(i);
}