List<int> Crescente(List<int> lista)
{
    List<int> listaNova = new();

    while(lista.Count > 0)
    {
        int menor = lista[0];

        foreach (var item in lista)
        {
            if (item <= menor) menor = item;
        }

        listaNova.Add(menor);
        lista.Remove(menor);
    }

    return listaNova;
}

List<int> lista = new List<int> { 7, 9, 1, 6, 2, 8 };
lista = Crescente(lista);

Console.WriteLine(string.Join(", ", lista));