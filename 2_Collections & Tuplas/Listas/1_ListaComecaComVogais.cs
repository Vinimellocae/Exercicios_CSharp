List<string> ListaComVogalNoInicio(List<string> Lista)
{
    List<string> ListaComVogais = new List<string> { };

    foreach (var item in Lista)
    {
        bool stringNaoNula = !string.IsNullOrWhiteSpace(item);

        if (stringNaoNula)
        {
            bool ComecaComVogal = "aeiou".Contains(item[0].ToString().ToLower());

            if (ComecaComVogal)
            {
                ListaComVogais.Add(item);
            }
        }
    }

    return ListaComVogais;
}

List<string> strings = new List<string> { "Abecedário", "Legal", "Bacana", "1ertv", "$frasd", "Urso", "Inteiro", "" };
List<string> NovaLista = ListaComVogalNoInicio(strings);

Console.WriteLine(string.Join(", ", NovaLista));
