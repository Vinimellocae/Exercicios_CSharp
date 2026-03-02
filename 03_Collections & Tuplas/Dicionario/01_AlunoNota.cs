Dictionary<string, int> Dicionario = new Dictionary<string, int>
{
    {"Alice", 10},
    {"Ana", 9},
    {"Cleiton", 5},
    {"Gabriel", 8}
};

foreach(var item in Dicionario)
{
    Console.WriteLine($"Estudante: {item.Key}, Nota: {item.Value}");
}