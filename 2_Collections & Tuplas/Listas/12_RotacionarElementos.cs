List<int> Lista = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int ultimo = Lista[Lista.Count - 1];

for (int i = Lista.Count - 1; i > 0; i--)
{
    Lista[i] = Lista[i - 1];
}

Lista[0] = ultimo;

Console.WriteLine(string.Join(", ", Lista));

