Dictionary<string, int> Valores = new Dictionary<string, int>
{
  {"Primeiro", 8},
  {"Segundo", 9},
  {"Terceiro", 14},
  {"Quarto", 5},
};

var copiaDeValores = Valores.Keys.ToList();

foreach(var chave in copiaDeValores)
{
    Valores[chave] *= 2;
}

Console.WriteLine(string.Join(", ", Valores));