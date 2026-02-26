Dictionary<string, int> Dicionario = new Dictionary<string, int>
{
    {"Cachorro", 5},
    {"Gato", 2},
    {"Tucano", 3},
    {"Elefante", 2}
};

foreach(KeyValuePair<string, int> item in Dicionario)
{
    Console.WriteLine($"Animal: {item.Key}, Quantidade: {item.Value}");
}