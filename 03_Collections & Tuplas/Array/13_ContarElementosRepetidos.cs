int[] array = {1, 1, 4, 5, 6, 7, 9, 6, 7, 3, 4};
List<int> novoArray = new List<int> {};
int Contador = 0;


foreach(var item in novoArray)
{
    if(!novoArray.Contains(item))
    {
        novoArray.Add(item);
    }
    else
    {
        Contador += 1;
    }
}

Console.WriteLine($"O array possui {Contador} itens repetidos");