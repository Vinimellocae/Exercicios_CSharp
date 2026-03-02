List<int> Lista = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

while (Lista.Count - 1 >= 0)
{
    Lista.Remove(Lista[0]);
}

Console.WriteLine(string.Join(", ", Lista));