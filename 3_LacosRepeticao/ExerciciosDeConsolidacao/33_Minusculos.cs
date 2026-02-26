string frase = "ISSO É UMA FRASE MUITO TOP";
string fraseNova = "";

foreach (var Caracter in frase)
{
    fraseNova += char.ToLower(Caracter);
}

frase = fraseNova;

Console.WriteLine(frase);