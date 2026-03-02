int[] Lista = { 5, 8, 21, 31, 2 };

int[] Resultado = Lista.Select(n => n * 2).ToArray();

Console.WriteLine(string.Join(", ", Resultado));
