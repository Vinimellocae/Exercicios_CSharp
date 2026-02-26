string Sequencia = "Hoje é quarta feira meus bacanos!";
string Invertida = "";

foreach (var letra in Sequencia.Reverse())
{
    Invertida += letra;
}

Console.WriteLine(Invertida);