var Dicionario = new Dictionary<int, string>
{
  {2, "Dois"},  
  {4, "Quatro"},
  {3, "Três"},  
  {1, "Um"},  
};

var DicionarioOrganizado = new SortedDictionary<int, string>
{
  {2, "Dois"},  
  {4, "Quatro"},
  {3, "Três"},  
  {1, "Um"},  
};

Console.WriteLine("Dicionario comum:");
Console.WriteLine(string.Join(", ", Dicionario));
Console.WriteLine();

Console.WriteLine("Sorted Dictionary:");
Console.WriteLine(string.Join(", ", DicionarioOrganizado));
Console.WriteLine();