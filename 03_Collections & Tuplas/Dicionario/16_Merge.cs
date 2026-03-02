// Merge dictionary

Dictionary<int, string> MergearDicionario(Dictionary<int, string> dicionario1, Dictionary<int, string> dicionario2)
{
    Dictionary<int, string> Merged = new();

    foreach (var item in dicionario1)
    {
        Merged[item.Key] = item.Value;
    }

    foreach (var item in dicionario2)
    {
        Merged.TryAdd(item.Key, item.Value);
    }

    return Merged;
}

Dictionary<int, string> Dicionario1 = new Dictionary<int, string>
{
    {1, "Olá"},
    {2, "Oi"},
    {3, "Bom dia"},
    {4, "Boa noite"},
};

Dictionary<int, string> Dicionario2 = new Dictionary<int, string>
{
    {1, "Tchau"},
    {2, "Adeus"},
    {5, "Boa tarde"},
    {6, "Até logo"},
};

Dictionary<int, string> Merged = MergearDicionario(Dicionario1, Dicionario2);

Console.WriteLine(string.Join(", ", Merged));