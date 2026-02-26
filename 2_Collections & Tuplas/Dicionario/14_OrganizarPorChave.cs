Dictionary<string, int> Dicionario = new Dictionary<string, int>
{
    {"Legal", 1},
    {"Bom", 2},
    {"Ótimo", 1},
    {"Excelente", 1},
    {"Ok", 1},
};

var OrdenadoPorChave = Dicionario.OrderBy(item => item.Key).ToList();

Console.WriteLine(string.Join(", ", OrdenadoPorChave));