Dictionary<string, int> Dicionario = new Dictionary<string, int>
{
    {"Alice", 10},
    {"Ana", 9},
    {"Cleiton", 5},
    {"Gabriel", 8},
    {"Francisco", 10},
    {"Flavia", 8},
    {"Bruna", 2},
};

int contador = 0;

foreach(var nota in Dicionario.Values)
{
    if(nota > 7)
    {
        contador++;
    }
}

Console.WriteLine($"{contador} Alunos tiraram mais do que 7");