List<int> Inteiros = new List<int> {15, 43, 87, 91, 52, 2, 124, 41};
const int VALOR_PROCURADO = 2;

Console.WriteLine("Procurando valor...");

for(int i = 0; i < Inteiros.Count - 1; i++)
{
    if(Inteiros[i] == VALOR_PROCURADO)
    {
        Console.WriteLine("Valor encontrado! Encerrando buscas!");
    }
    else
    {
        Console.WriteLine($"Numero: {Inteiros[i]} ...");
        continue;
    }
    break;
}