List<string> Generos = new List<string> {"Pop", "Hard Rock", "Sertanejo", "Metal", "Nacional"};

foreach(var item in Generos)
{
    if(item == "Metal")
    {
        Console.WriteLine($"{item}! Genero encontrado!");
        return;
    }

    Console.WriteLine($"{item}...");
}