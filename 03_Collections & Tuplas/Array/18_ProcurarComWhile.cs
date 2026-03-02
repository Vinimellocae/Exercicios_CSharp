int[] ints = { 5, 8, 12, 43, 72, 91, 21, 42 };
const int NUMERO_PROCURADO = 42;
int i = 0;

while (true)
{
    if (i >= ints.Length) break;

    if (ints[i] == NUMERO_PROCURADO)
    {
        Console.WriteLine($"Numero {NUMERO_PROCURADO} presente no array!");
        return;
    }

    i++;
}

Console.WriteLine("Numero não encontrado!");