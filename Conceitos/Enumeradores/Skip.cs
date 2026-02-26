// Skip, Pula os primeiros itens de uma sequência
var Lista = new List<string> {"João", "Francisco", "Ana", "Raíssa", "Gabriela", "Marcos", "Gustavo", "Hugo"};

IEnumerable<string> PularOs5Primeiros = Lista.OrderBy(N => N).Skip(5); // Ordena em ordem alfaetica e pula os cinco primeiros
Console.WriteLine(string.Join(", ", PularOs5Primeiros));