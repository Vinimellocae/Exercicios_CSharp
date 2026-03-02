Dictionary<string, int> Dicionario = new Dictionary<string, int>
{
    {"PlayStation 2", 5},
    {"PlayStation 3", 7},
    {"Xbox 360", 1},
    {"Nintendo switch", 2},
};

var keys = Dicionario.Keys.ToList();

for(int i = 0; i < keys.Count; i++)
{
    Console.WriteLine(keys[i]);
}
