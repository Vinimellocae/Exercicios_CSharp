Dictionary<string, int> Dicionario = new Dictionary<string, int>
{
    {"Quartzo", 8},
    {"Ametista", 5},
    {"Topázio", 4},
    {"Titânio", 3}
};

foreach(var item in Dicionario.Keys)
{
    Console.WriteLine(item);
}
