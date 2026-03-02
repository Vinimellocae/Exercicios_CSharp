static int BuscaBinaria(int[] array, int valor)
{
    int inicio = 0;
    int fim = array.Length - 1;

    while (inicio <= fim)
    {
        int meio = (inicio + fim) / 2;

        if (array[meio] == valor)
        {
            return meio;
        }
        else if (valor < array[meio])
        {
            fim = meio - 1;
        }
        else
        {
            inicio = meio + 1;
        }
    }
    return -1;
}

int[] Numeros = [10, 15, 94, 95, 100, 135, 800];

Console.WriteLine(BuscaBinaria(Numeros, 15)); // retorna o indice donde esta o numero