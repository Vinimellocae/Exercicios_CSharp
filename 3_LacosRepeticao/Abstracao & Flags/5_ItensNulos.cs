List<string> nomes = new List<string> { "Robson", "Francisco", "Marta", "Gabriela", "Carlos", "", "", "Marcos" };

nomes.ForEach((n) =>
{
    if (string.IsNullOrEmpty(n))
    {
        n = "Valor padrão";
        Console.WriteLine(n);
    } else
    {
        Console.WriteLine(n);
    }
});
