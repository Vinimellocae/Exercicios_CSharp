List<double> precos = new List<double> {15, 39, 450, 31, 67, 42, 21, 11};

precos.ForEach(N =>
{
    N -= N * 0.1; 
    Console.WriteLine(N);
});