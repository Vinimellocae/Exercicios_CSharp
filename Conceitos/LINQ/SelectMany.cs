// SelectMany transforma “listas dentro de listas” em uma lista única.
// Ele achata coleções aninhada

class Program
{
    static void Main()
    {
        var Listas = new List<List<int>> // Lista de Listas inteiras
        {
            new List<int> {1, 2, 3, 4},
            new List<int> {5, 6},
            new List<int> {7, 8, 9}
        }; 

        var ListaExplodida = Listas.SelectMany(L => L).ToList();

        Console.WriteLine(string.Join(", ", ListaExplodida)); // Saida: 1, 2, 3, 4, 5, 6, 7, 8, 9
    }
}