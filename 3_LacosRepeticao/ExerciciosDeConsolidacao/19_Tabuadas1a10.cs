for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"Tabuada do {i}");

    for (int j = 0; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i * j}");
    }

    Console.WriteLine();
}