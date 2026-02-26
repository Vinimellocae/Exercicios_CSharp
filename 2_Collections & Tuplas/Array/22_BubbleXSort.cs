int[] BubbleSort(int[] lista)
{

    for (int i = 0; i < lista.Length - 1; i++)
    {
        for (int j = 0; j < lista.Length - 1 - i; j++)
        {
            if (lista[j] > lista[j + 1])
            {
                int temp = lista[j];
                lista[j] = lista[j + 1];
                lista[j + 1] = temp;
            }
        }
    }

    return lista;
}

int[] inteiros1 = {1, 18, 7, 9, 42, 3};
Array.Sort(inteiros1);

int[] inteiros2 = {1, 18, 7, 9, 42, 3};
BubbleSort(inteiros2);

Console.WriteLine(string.Join(", ", inteiros1));
Console.WriteLine(string.Join(", ", inteiros2));