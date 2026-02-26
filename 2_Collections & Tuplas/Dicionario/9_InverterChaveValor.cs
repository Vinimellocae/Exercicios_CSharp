Dictionary<string, string> InverterChaveValor(Dictionary<string, string> Dicionario)
{
    Dictionary<string, string> NovoDicionario = new();

    foreach(var item in Dicionario)
    {
        NovoDicionario.Add(item.Value, item.Key);
    }

    return NovoDicionario;
}

Dictionary<string, string> Nomes = new Dictionary<string, string>
{
  {"Machado", "de Assis"},  
  {"Manoel", "da Nobrega"},  
  {"Caetano", "Velozo"},  
  {"Fausto", "Silva"},  
};

Dictionary<string, string> DicionarioInvertido = InverterChaveValor(Nomes);

foreach(var item in DicionarioInvertido)
{
    Console.WriteLine($"{item.Key} {item.Value}");
}
