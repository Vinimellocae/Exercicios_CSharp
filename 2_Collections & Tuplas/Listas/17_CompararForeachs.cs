List<int> Lista = new List<int> {1,2,3,4,5,6,7,8};

// ForEach

Lista.ForEach(N =>
{
   Console.WriteLine(N * 2); 
});

// Foreach

foreach(var item in Lista)
{
    Console.WriteLine(item * 2);
}