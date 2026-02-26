List<int> Inteiros = new List<int>{1, 35, 342, 76, 92, 14, 51, 0, 4, 1, 5, 7, 8, 45};
List<int> Impares = new List<int> {};

Inteiros.Sort();

Inteiros.ForEach(N =>
{
   if(N % 2 == 1) Impares.Add(N); 
});

foreach(var item in Impares)
{
    Console.WriteLine(item);
}