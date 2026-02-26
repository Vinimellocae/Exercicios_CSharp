// Mostrar que não há índice em IEnumerable
IEnumerable<string> Nomes = new[] {"Ana", "João", "Kaio"};

// Nomes[0];
foreach(var nome in Nomes)
{
    Console.WriteLine(nome);
}