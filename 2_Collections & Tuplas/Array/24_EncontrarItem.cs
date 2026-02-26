bool encontrou = false;

int[] Lista = {1, 8, 32, 17, 93, 41};
int Procurado = 32;

if(Lista.Any(n => n == Procurado)) encontrou = true;

Console.WriteLine(encontrou ? "Presente na lista!" : "Não está na lista");