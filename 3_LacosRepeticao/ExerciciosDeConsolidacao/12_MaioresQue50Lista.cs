List<int> Lista = new List<int> {50, 76, 43, 27, 92, 1243, 34, 3, 15, 71, 62};
int Contador = 0, LIMIAR = 50;

foreach(var elemento in Lista)
{
    if(elemento > LIMIAR) Contador++;
}

Console.WriteLine($"Elementos maiores que 50: {Contador}");