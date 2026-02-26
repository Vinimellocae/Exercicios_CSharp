List<double> notas = new List<double> { 4.3, 10, 8.2, 5.5, 9.1, 6.7, 8.2, 9, 3.7 };
double soma = 0;

notas.ForEach(N =>
{
    soma += N;
});

double media = soma / notas.Count;

Console.WriteLine($"A média da turma é {media:F2}");