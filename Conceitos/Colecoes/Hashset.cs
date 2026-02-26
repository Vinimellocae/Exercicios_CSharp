// HASHSET -- Armazena apenas valores ÚNICOS
HashSet<int> set = new HashSet<int> { 1, 2, 3, 3, 4 };
Console.WriteLine("HashSet inicial:");
Console.WriteLine(string.Join(", ", set)); // Saida:  1, 2, 3, 4
Console.WriteLine();

// ADD -- Adiciona um item (retorna false se já existir)
Console.WriteLine("ADD:");
bool adicionou = set.Add(2); // Já existe
Console.WriteLine($"Adicionou 2? {adicionou}");
set.Add(5);
Console.WriteLine(string.Join(", ", set));
Console.WriteLine();

// UNIONWITH -- Une dois conjuntos (sem repetir)
Console.WriteLine("UNIONWITH:");
HashSet<int> a = new HashSet<int> { 1, 2, 3 };
HashSet<int> b = new HashSet<int> { 3, 4, 5 };
a.UnionWith(b);
Console.WriteLine(string.Join(", ", a));
Console.WriteLine();

// INTERSECTWITH -- Mantém apenas os itens em comum
Console.WriteLine("INTERSECTWITH:");
HashSet<int> c = new HashSet<int> { 1, 2, 3 };
HashSet<int> d = new HashSet<int> { 2, 3, 4 };
c.IntersectWith(d);
Console.WriteLine(string.Join(", ", c));
Console.WriteLine();

// EXCEPTWITH -- Remove os itens que existem no outro HashSet
Console.WriteLine("EXCEPTWITH:");
HashSet<int> e = new HashSet<int> { 1, 2, 3, 4 };
HashSet<int> f = new HashSet<int> { 2, 4 };
e.ExceptWith(f);
Console.WriteLine(string.Join(", ", e));
Console.WriteLine();