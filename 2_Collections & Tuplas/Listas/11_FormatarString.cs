List<string> FormatarString(List<string> Lista)
{
    List<string> Formatacao = new List<string> {};

    foreach (var item in Lista)
    {
        if (!string.IsNullOrWhiteSpace(item))
        {
            string texto;
            texto = item.ToLower();
            texto = char.ToUpper(texto[0]) + texto.Substring(1);
            Formatacao.Add(texto);
        }
    }

    return Formatacao;
}

List<string> ListaStrings = new List<string> { "bOM DiA", "lEGAL", "INTEressanTE", "ULTIMa" };
ListaStrings = FormatarString(ListaStrings);

Console.WriteLine(string.Join(", ", ListaStrings));
