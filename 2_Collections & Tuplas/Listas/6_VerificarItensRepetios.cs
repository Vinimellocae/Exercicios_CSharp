List<int> Lista = new List<int> { 1, 2, 2, 3, 7, 8, 7, 9 };

var set = new HashSet<int> {};

foreach(var item in Lista)
{
    if(!set.Add(item)) // O "if" adiciona o item no Hashset. Se ele já exisitir o if retorna false
    {
        Console.WriteLine("Há itens repetidos!");
        return;
    }
}

Console.WriteLine("Todos os itens são únicos!");