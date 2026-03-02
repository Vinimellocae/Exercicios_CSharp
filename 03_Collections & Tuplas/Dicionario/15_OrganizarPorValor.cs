// Ordenar o Dicionário por Valor --> Ordem Crescente

Dictionary<string, int> Dicionario = new Dictionary<string, int>
{
    {"Legal", 10},
    {"Bom", 14},
    {"Ótimo", 1},
    {"Excelente", 12},
    {"Ok", 5},
};

var OrdenadoPorChave = Dicionario.OrderBy(item => item.Value).ToList();

Console.WriteLine(string.Join(", ", OrdenadoPorChave));