List<int> Lista = new List<int> {50, 76, 43, 27, 92, 1243, 34, 3, 15, 71, 62};
bool contem = false;
int Procurado = 71;

foreach(var elemento in Lista)
{
    if(elemento == Procurado) {
        contem = true; 
        break;
    }
}

Console.WriteLine(contem ? $"{Procurado} está na lista" : $"{Procurado} não está na lista");