Dictionary<string, int> Itens = new Dictionary<string, int>
{
  {"Machado", 1},
  {"Espada", 1},
  {"Picareta", 2},
  {"Pá", 1},
};

string ItemProcurado = "Machadoss";

if (Itens.TryGetValue(ItemProcurado, out int value))
{
    Console.WriteLine("Valor Encontrado na lista!");
}
else
{
    Console.WriteLine($"Valor {ItemProcurado} NÃO está na lista");
}