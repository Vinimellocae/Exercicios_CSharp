List<string> Lista = new List<string> {"Marcos", "Reginaldo", "João", "Jefferson", "Isadora", "Lucas"};

foreach(var nome in Lista)
{
    if(nome.StartsWith("J")) {
        Console.WriteLine(nome);
    }
}