List<int> Lista = new List<int> { 1, 52, 19, 42, 17, 32, 8, 54 };

List<int> MaioresDe40 = Lista.FindAll(N => N > 40);
Console.WriteLine(string.Join(", ", MaioresDe40));