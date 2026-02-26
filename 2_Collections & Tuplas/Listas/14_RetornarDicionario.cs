Dictionary<string, int> retornarDicionario(List<string> Lista)
{
    Dictionary<string, int> Dicionario = new();

    foreach (var item in Lista)
    {
        if (Dicionario.ContainsKey(item))
        {
            Dicionario[item]++; // [item]++ É a mesma coisa de soma 1 ao valor do item
        }
        else
        {
            Dicionario[item] = 1;
        }
    }

    return Dicionario;

}

List<string> strings = new List<string> { "Oi", "Oi", "Oi", "Legal", "Legal", "Bom" };
Dictionary<string, int> Dicionario = retornarDicionario(strings);

foreach (var item in Dicionario)
{
    Console.WriteLine($"{item.Key} --> {item.Value}");
}