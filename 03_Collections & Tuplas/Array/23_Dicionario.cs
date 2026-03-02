static Dictionary<int, int> ContarElementos(int[] array)
{
    var Contagem = new Dictionary<int, int> {};

    foreach(int item in array)
    {
        if(Contagem.ContainsKey(item))
        {
            Contagem[item]++;
        }
        else
        {
            Contagem[item] = 1;
        }
    }

    return Contagem;
}

int[] Lista = {1,2,3,4,4,2,9,14};
Dictionary<int, int> Contar = ContarElementos(Lista);

foreach(var valor in Contar)
{
    Console.WriteLine($"O valor {valor.Key} aparece na lista {valor.Value} vez(ez)");
}