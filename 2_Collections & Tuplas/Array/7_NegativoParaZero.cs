int[] Numeros = [-5, 43, 71, 9, -3, 8, -11];

for(int i = 0; i <= Numeros.Length; i++)
{
    if(Numeros[i] < 0) Numeros[i] = 0;
    Console.WriteLine(Numeros[i]);
}