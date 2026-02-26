List<int> Inteiros = new List<int>{1, 35, 342, 76, 92, 14, 51, 0, 4, 1, 5, 7, 8, 45};
List<int> Pares = new List<int> {};

Inteiros.Sort();

Inteiros.ForEach(N =>
{
   if(N % 2 == 0) Pares.Add(N); 
});

foreach(var item in Pares)
{
    Console.WriteLine(item);
}