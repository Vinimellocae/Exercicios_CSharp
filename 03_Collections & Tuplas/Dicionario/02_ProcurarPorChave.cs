Dictionary<string, int> Dicionario = new Dictionary<string, int>
{
    {"Alice", 10},
    {"Ana", 9},
    {"Cleiton", 5},
    {"Gabriel", 8}
};

string AlunoProcurado = "Cleiton";

if(Dicionario.TryGetValue(AlunoProcurado, out int nota)) 
{
    Console.WriteLine($"A nota de {AlunoProcurado} é {nota}");
}
else
{
    Console.WriteLine("Chave não encontrada");
}