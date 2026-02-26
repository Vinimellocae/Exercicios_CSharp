// Where -- Filtra uma lista seguindo uma condição, não altera listas

int[] lista = { 1, 5, 8, 12 };
var filtrada = lista.Where(n => n > 5).ToArray(); // filtrar os menores de 5

Console.WriteLine(string.Join(", ", filtrada));