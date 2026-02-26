List<int> Lista = new List<int> {10, 234, 43, 12, 73};

Lista.ForEach(Elemento =>
{
   Elemento -= Elemento;
   Console.WriteLine(Elemento); 
});