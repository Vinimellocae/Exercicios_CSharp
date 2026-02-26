// Dicionários não podem ser acessados com o Indice, o que obriga a utiliazar "ElementAt(i)"
// e ele é ineficiente para dicioários grandes

Dictionary<string, int> Dicionario = new Dictionary<string, int> {
    { "PlayStation 2", 5 },
    { "PlayStation 3", 7 },
    { "Xbox 360", 1 },
    { "Nintendo switch", 2 },
};

List<string> Chaves = new();

for (int i = 0; i < Dicionario.Count; i++)
{
    Chaves.Add(Dicionario.ElementAt(i).Key); // Aplicação dele
}

Console.WriteLine(string.Join(", ", Chaves));