int MaiorValorNoDicionario(Dictionary<string, int> Dicionario)
{
    int MaiorValor = 0;

    foreach(var item in Dicionario.Values)
    {
        if(item >= MaiorValor)
        {
            MaiorValor = item;
        }
    }

    return MaiorValor;
}

Dictionary<string, int> Compras = new Dictionary<string, int>
{
    {"Copos Descartaveis", 500},
    {"Talheres", 800},
    {"Salgadinhos", 900},
    {"Balões", 40},
};

int MaiorValor = MaiorValorNoDicionario(Compras);

Console.WriteLine(MaiorValor);