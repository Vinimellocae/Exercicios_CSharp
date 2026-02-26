// Take pega os primeiros itens de uma sequência
var Notas = new List<int> {6, 5, 6, 8, 10, 10, 7, 7, 9, 9};

IEnumerable<int> CincoMelhoresNotas = Notas.OrderByDescending(nota => nota).Take(5);
Console.WriteLine(string.Join(", ", CincoMelhoresNotas)); // saida: 10, 10, 9, 9, 8