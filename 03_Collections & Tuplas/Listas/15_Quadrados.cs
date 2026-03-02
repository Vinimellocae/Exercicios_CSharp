List<int> Inteiros = new List<int> {1,2,3,4,5,6,7,8};
List<int> Quadrados = Inteiros.Select(N => N * N).ToList();

Console.WriteLine(string.Join(", ", Quadrados));