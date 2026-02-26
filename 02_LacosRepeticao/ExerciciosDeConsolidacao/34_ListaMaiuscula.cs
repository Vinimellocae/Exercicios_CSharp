List<string> Lista = new List<string> {"sapo", "gato", "cachorro", "papagaio", "jacaré", "bem-te-vi"};
List<string> ListaUpdated = new List<string> {};
string Palavra = "";

foreach(var item in Lista)
{
    foreach(var Caracter in item)
    {
        Palavra += char.ToUpper(Caracter);
    }

    ListaUpdated.Add(Palavra);
    Palavra = ""; 
}

Lista = ListaUpdated;

foreach(var item in Lista)
{
    Console.WriteLine(item);
}