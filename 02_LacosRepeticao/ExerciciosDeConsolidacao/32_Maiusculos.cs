string Frase = "Uma string completamente legal e aleatória";
string NovaFrase = "";

foreach(var Caracter in Frase)
{
    NovaFrase += char.ToUpper(Caracter);
}

Frase = NovaFrase;

Console.WriteLine(Frase);