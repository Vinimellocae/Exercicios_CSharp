var Alunos = new Dictionary<string, Dictionary<string, double>>
{
    ["Ana"] = new Dictionary<string, double>
    {
        {"Matemática", 8.5},
        {"Português", 7.5},
        {"Inglês", 9.0},
    },
    ["Paulo"] = new Dictionary<string, double>
    {
        {"Matemática", 8.0},
        {"Português", 10.0},
        {"Inglês", 4.5},
    },
    ["Hugo"] = new Dictionary<string, double>
    {
        {"Matemática", 6.0},
        {"Português", 7.5},
        {"Inglês", 10.0},
    },
    ["Roberta"] = new Dictionary<string, double>
    {
        {"Matemática", 10.0},
        {"Português", 10.0},
        {"Inglês", 10.0},
    },
};

Console.WriteLine("Nota dos alunos:");
Console.WriteLine();

foreach (var aluno in Alunos)
{
    Console.WriteLine($"{aluno.Key}:");

    foreach (var materia in aluno.Value)
    {
        Console.WriteLine($" - {materia.Key} = {materia.Value}");
    }
}