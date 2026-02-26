IEnumerable<int> ints = Enumerable.Range(0, 16);

ints = ints.ToArray();

for (int i = 0; i < ints.Count(); i++)
{
    Console.WriteLine(i);
}