var Lista = new List<string> {"João", "Francisco", "Ana", "Raíssa", "Gabriela", "Marcos", "Gustavo", "Hugo"};

IEnumerable<string> PularOs5Primeiros = Lista.OrderBy(N => N).Skip(5);
Console.WriteLine(string.Join(", ", PularOs5Primeiros));