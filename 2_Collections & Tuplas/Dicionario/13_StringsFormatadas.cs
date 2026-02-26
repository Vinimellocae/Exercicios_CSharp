Dictionary<string, int> Dicionario = new Dictionary<string, int>
{
    {"Alice", 10},
    {"Ana", 9},
    {"Cleiton", 5},
    {"Gabriel", 8},
    {"Francisco", 10},
    {"Flavia", 8},
    {"Bruna", 2},
};

List<string> stringsFormatadas = Dicionario.Select(S => $"{S.Key}: {S.Value}").ToList();
Console.WriteLine(string.Join(", ", stringsFormatadas));