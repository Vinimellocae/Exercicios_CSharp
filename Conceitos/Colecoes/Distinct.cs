// Parecido com Hashset, remove itens repetidos

var Lista = new List<int> { 1, 7, 8, 9, 9, 15, 15, 7, 8, 9, 9};
IEnumerable<int> Distintos = Lista.Distinct().OrderBy(n => n);
Console.WriteLine(string.Join(", ", Distintos)); // Saida: 1, 7, 8, 9, 15