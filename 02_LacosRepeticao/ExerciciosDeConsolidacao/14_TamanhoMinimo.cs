int TamanhoMinimo = 6;
List<string> Lista = new List<string> {"Marcos", "Reginaldo", "João", "Jefferson", "Isadora", "Lucas"};

foreach(var nome in Lista)
{
    if(nome.Length >= TamanhoMinimo) {
        Console.WriteLine(nome);
    }
}