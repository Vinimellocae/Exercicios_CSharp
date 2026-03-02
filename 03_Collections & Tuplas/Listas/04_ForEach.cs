List<int> Lista = new List<int> {1,2,3,4,5,6,7,8};
List<int> ListaNova = new List<int>  {}; 

Lista.ForEach(N =>
{   
    N *= 10;
    ListaNova.Add(N);
});

Lista = ListaNova;

Console.WriteLine(string.Join(", ", Lista));