int[] lista = { 1, 2, 3 };

int primeiro = lista[0];

for (int i = 0; i < lista.Length - 1; i++)
{
    lista[i] = lista[i + 1];
}

lista[lista.Length - 1] = primeiro;

Console.WriteLine(string.Join(", ", lista));
