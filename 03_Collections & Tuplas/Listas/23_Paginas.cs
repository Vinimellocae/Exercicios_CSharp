List<string> ItensDaPagina(List<string> Lista, int NumeroDaPagina, int QTDEitensPorPagina)
{
    int IndiceInicial = Lista.Count - 1 / QTDEitensPorPagina;
    int IndiceFinal = IndiceInicial + QTDEitensPorPagina;

    List<string> ListaFiltrada = new();

    for(int i = IndiceInicial; i <= IndiceFinal; i++)
    {
        ListaFiltrada.Add(Lista[i]);
    }

    return ListaFiltrada;
} 

List<string> Lista = new List<string> {"Oi", "Muito", "Bom", "Dia", "Como", "Você", "Está?"};
List<string> PalavrasDaPagina = ItensDaPagina(Lista, 2, 2);

Console.WriteLine(string.Join(", ", PalavrasDaPagina));
