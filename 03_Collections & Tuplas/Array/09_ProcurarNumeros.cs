int[] Numeros = [45, 87, 24, 3, 0, 71, 82, 10];

const int NUMERO_PROCURADO = 3;

for(int i = 0; i <= Numeros.Count() - 1; i++)
{
    if(Numeros[i] == NUMERO_PROCURADO)
    {
        Console.WriteLine($"O número procurado se encontra no indice = {i}");
        return;
    }
}