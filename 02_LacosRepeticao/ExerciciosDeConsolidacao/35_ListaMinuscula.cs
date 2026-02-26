List<string> Lista = new List<string> {"SAPO", "GATO", "CACHORRO", "PAPAGAIO", "JACARÉ", "BEM-TE-VI"};
List<string> ListaUpdated = new List<string> {};

foreach(var item in Lista)
{
    ListaUpdated.Add(item.ToLower());
}

Lista = ListaUpdated;

foreach(var item in Lista)
{
    Console.WriteLine(item);
}