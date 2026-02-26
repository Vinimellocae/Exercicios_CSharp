int[,] Matriz =
{
    { 1, 4, 8 },
    { 5, 7, 9 },
    { 2, 5, 5 }
};

int DiagonalPrincipal = 0;

for(int i = 0; i < 3; i++)
{
    DiagonalPrincipal += Matriz[i, i];    
}

Console.WriteLine(DiagonalPrincipal);