List<int> Lista = new List<int> { 1, 52, 19, 42, 17, 32, 8, 54, 101 };

if (Lista.All(N => N > 0))
{
    Console.WriteLine("Todos os números são Maiores que 0");
}
else
{
    Console.WriteLine("Nem todos os números são maiores que 0");
}