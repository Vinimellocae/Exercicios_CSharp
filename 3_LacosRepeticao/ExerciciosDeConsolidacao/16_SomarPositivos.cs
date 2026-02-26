List<int> Lista = new List<int> {5, 4, 9, -2, -9, 13, 12, -8};
int soma = 0;

foreach(var numero in Lista)
{
    if(numero < 0) continue;
    soma += numero;
}

Console.WriteLine(soma);