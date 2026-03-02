int[] lista = { 5, 8, 12, 43, 72, 9 };

for (int i = 0; i < lista.Length - 1; i++)
{
    for (int j = 0; j < lista.Length - 1 - i; j++)
    {
        if (lista[j] > lista[j + 1])
        {
            // troca
            int temp = lista[j];
            lista[j] = lista[j + 1];
            lista[j + 1] = temp;
        }
    }
}

Console.WriteLine(string.Join(", ", lista));
