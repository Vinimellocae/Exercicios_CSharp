int[,] Matriz =
{
    { 1, 4, 8 }, 
    { 5, 7, 9 }, 
    { 2, 5, 5 } 
};

int DiagonalSecundaria = 0;

for(int i = 0; i < 3 ; i++)
{
    DiagonalSecundaria += Matriz[i, 2 - i];
}

Console.WriteLine(DiagonalSecundaria);