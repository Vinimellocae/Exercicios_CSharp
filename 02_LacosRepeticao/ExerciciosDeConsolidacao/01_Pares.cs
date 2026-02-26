// Imprimir pares de  a 100

for(int i = 0; i <= 100; i++)
{
    bool ehhImpar = i % 2 == 1;
    if(ehhImpar) continue;
    Console.WriteLine(i);
}