List<int> Lista = new List<int> { 1, 52, 19, 42, 17, 32, 8, 54, 101 };

if (Lista.Any(N => N > 100))
{
    Console.WriteLine("Há pelo menos um numero maior que 100");
}
else
{
    Console.WriteLine("Nenhum item da lista é maior que 100!");
}