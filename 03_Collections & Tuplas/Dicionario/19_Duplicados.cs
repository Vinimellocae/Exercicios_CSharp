List<int> ValoresRepetidos(Dictionary<int, string> dicionario)
{
    Dictionary<string, int> contador = new();
    List<int> resultado = new();

    foreach (var item in dicionario)
    {
        if (!contador.ContainsKey(item.Value))
        {
            contador[item.Value] = 0;
        }

        contador[item.Value]++;
    }

    foreach (var item in dicionario)
    {
        if (contador[item.Value] > 1)
        {
            resultado.Add(item.Key);
        }
    }

    return resultado;
}


var dict = new Dictionary<int, string>
{
    {1, "Olá"},
    {2, "Oi"},
    {3, "Olá"},
    {4, "Oi"},
    {5, "Bom dia"}
};

var resultado = ValoresRepetidos(dict);

Console.WriteLine("Chaves com valores repetidos na lista:");
Console.WriteLine(string.Join(", ", resultado));