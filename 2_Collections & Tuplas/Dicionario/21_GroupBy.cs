var Dicionario = new Dictionary<string, int>
{
    {"Alice", 10},
    {"Ana", 9},
    {"Cleiton", 5},
    {"Gabriel", 8},
    {"Francisco", 10},
    {"Flavia", 8},
    {"Bruna", 2},
};

var notasAgrupadas = Dicionario.GroupBy(n => n.Value);

foreach(var grupo in notasAgrupadas)
{
    Console.Write($"Nota {grupo.Key}");
    
    foreach(var aluno in grupo)
    {
        Console.WriteLine($" - {aluno.Key}");    
    }
}