// Usando Foreach

int[] Numeros = [55, 96, 41, 22, 38, 12, 17, 9, 164];
int menor = 100;

foreach (var N in Numeros)
{
    if (N < menor) menor = N;
}

Console.WriteLine(menor);

// Usando for

menor = 100;

for (int i = 0; i <= Numeros.Count() - 1; i++)
{
    if (Numeros[i] < menor) menor = Numeros[i];
}

Console.WriteLine(menor);