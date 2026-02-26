int[,] Matriz =
{
    { 1, 4, 8, 0}, 
    { 5, 7, 9, 4}, 
    { 2, 5, 5, 7}, 
    { 2, 2, 1, 9} 
};

int soma = 0;

foreach(var item in Matriz)
{
    soma += item;
}

Console.WriteLine(soma);