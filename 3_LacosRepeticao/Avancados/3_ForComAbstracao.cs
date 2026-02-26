int CalculoEsquisito(int N)
{
    int Valor = 0;
    return N * 5 + N * 4 + N - 3;
}

for (int i = 1; i <= 10; i++)
{
    int Resultado = CalculoEsquisito(i);
    Console.WriteLine(Resultado);
}