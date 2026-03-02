static int[] RevisarArray(int[] array)
{
    List<int> resultado = new List<int> {};

    foreach(var item in array)
    {
        if(!resultado.Contains(item)) {
            resultado.Add(item);
        }
    }
    
    return resultado.ToArray();
}

int[] Entrada = [1, 1, 4, 5, 6, 7, 9, 6, 7, 3, 4];
int[] Saida = RevisarArray(Entrada);

foreach(var item in Saida)
{
    Console.WriteLine(item);
}