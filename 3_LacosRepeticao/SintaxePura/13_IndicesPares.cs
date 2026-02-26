// Imprimir apenas índices pares

string[] array = ["Tonto", "Besta", "Inteligente", "Rapido", "Esperto", "Bacana", "Raio laser"];

for(int i = 0 ; i <= array.Count(); i++)
{
    if(i % 2 == 0)
    {
        Console.WriteLine(array[i]);
    }
}