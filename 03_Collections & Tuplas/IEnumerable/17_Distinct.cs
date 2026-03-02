var Lista = new List<int> { 1, 15, 15, 7, 8, 9, 9 };
IEnumerable<int> Distintos = Lista.Distinct().OrderBy(n => n);
Console.WriteLine(string.Join(", ", Distintos));