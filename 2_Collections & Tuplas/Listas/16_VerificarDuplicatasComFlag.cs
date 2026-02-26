List<int> Inteiros = new List<int> { 1, 2, 3, 4, 3, 5, 6, 7, 8 };
Dictionary<int, int> Dicionario = new();

bool Duplicado = false;

foreach (var item in Inteiros)
{
    if (Dicionario.ContainsKey(item))
    {
        Duplicado = true;
        break;
    }
    else
    {
        Dicionario[item] = 1;
    }
}

if (Duplicado)
{
    Console.WriteLine("Há itens duplicados na lista!");
}
else
{
    Console.WriteLine("Não há duplicatas na lista!");
}
