List<int> Inteiros = new List<int> {1, 4, 6, 7, 9, 10};

List<string> Strings = Inteiros.ConvertAll(N => N.ToString());

Console.WriteLine(string.Join(", ", Strings));