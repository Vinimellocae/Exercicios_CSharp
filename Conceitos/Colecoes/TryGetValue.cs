Dictionary<string, int> Dicionario = new Dictionary<string, int>
{
    {"Alice", 10},
    {"Ana", 9},
    {"Cleiton", 5},
};

string AlunoProcurado = "Cleiton";

if(Dicionario.TryGetValue(AlunoProcurado, out int nota)) // Tenta pegar o valor de "AlunoProcurado" e o armazena em "nota"
{
    Console.WriteLine($"A nota de {AlunoProcurado} é {nota}");
}
else
{
    Console.WriteLine("Chave não encontrada");
}