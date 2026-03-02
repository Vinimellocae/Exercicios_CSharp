Dictionary<string, int> Dicionario = new Dictionary<string, int>
{
    {"Corinthians", 1},
    {"Santos", 2},
    {"Palmeiras", 3},
    {"São Paulo", 4}
};

string ChaveProcurada = "Vasco";

if (Dicionario.TryGetValue(ChaveProcurada, out int value))
{
    Console.WriteLine($"{ChaveProcurada}, {value}");
}
else
{
    Console.WriteLine($"A chave '{ChaveProcurada}' não foi encontrada no dicionário.");

}