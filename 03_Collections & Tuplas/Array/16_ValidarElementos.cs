int[] Lista = { 5, 8, 21, 31, -2, 8, 9 };

bool PossuiNegativo = Lista.Any(N => N < 0);

if(PossuiNegativo)
{
    Console.WriteLine("O array possui números negativos");
    return;
}
else
{
    Console.WriteLine("O array possui apenas números positivos");
}

Console.WriteLine(string.Join(", ", Lista));