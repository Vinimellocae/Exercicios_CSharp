List<string> Nomes = new List<string>
{
    "João",
    "Maria",
    "Gustavo",
    "Fernanda",
    "Paula"
};

IEnumerable<string> strings = Nomes;

strings = strings.OrderBy(N => N);

Console.WriteLine(string.Join(", ", strings));