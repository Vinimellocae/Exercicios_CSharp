string Palavra = "pneumoultramicroscopicossilicovulcanoconiose";
int Contador = 0;

foreach(var Caracter in Palavra)
{   
    if(!(char.IsLetter(Caracter))) continue;

    if("aeiou".Contains(char.ToLower(Caracter)))
    {
        Contador += 1;
    }
}

Console.WriteLine($"A palavra {Palavra} contém {Contador} vogais!");