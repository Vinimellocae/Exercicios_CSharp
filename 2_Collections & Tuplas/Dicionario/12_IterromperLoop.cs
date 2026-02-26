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

int ValorProcurado = 5;
bool Parar = false;

foreach(var item in Dicionario.Values)
{
    if(item == ValorProcurado)
    {
        Parar = true;
        break;
    }
}

if(Parar)
{
    Console.WriteLine("Nota encontrada!");
}
else
{
    Console.WriteLine("Nota não foi encontrada!");
}