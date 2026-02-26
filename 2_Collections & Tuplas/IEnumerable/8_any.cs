IEnumerable<int> numeros = Enumerable.Range(8, 3);

bool HaMultiplosDeSete = numeros.Any(N => N % 7 == 0);

Console.WriteLine(HaMultiplosDeSete ? "Há multiplos de 7" : "Não há multiplos de 7");