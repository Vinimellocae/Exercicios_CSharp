static int[] ConcatenarArrays(int[] array1, int [] array2)
{
    List<int> Concatenados = new List<int> {};

    foreach(var a in array1)
    {
        Concatenados.Add(a);
    }

    foreach(var a in array2)
    {
        Concatenados.Add(a);
    }

    return Concatenados.ToArray();
}

int[] vitima1 = [1, 5, 8, 9, 15];
int[] vitima2 = [4, 7, 14, 2, 1];

int[] novoArray = ConcatenarArrays(vitima1, vitima2);

foreach(var a in novoArray)
{
    Console.WriteLine(a);
}