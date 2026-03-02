IEnumerable<int> sequencia1 = Enumerable.Range(0, 11);
IEnumerable<int> sequencia2 = Enumerable.Range(50, 11);

IEnumerable<int> sequenciaConcatenada = sequencia1.Concat(sequencia2);

Console.WriteLine(string.Join(", ", sequenciaConcatenada));