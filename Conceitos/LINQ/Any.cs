/* ANY - Procura em uma lista qualquer valor que atenda a uma condição e retorna (True) ou (False).
Se ao menos um valor atender a condição o retorno é true */

bool encontrado = false;

int[] Lista = {1, 8, 32, 17, 93, 41};
int Procurado = 32;

if(Lista.Any(n => n == Procurado)) encontrado = true;

Console.WriteLine(encontrado ? "Presente na lista!" : "Não está na lista");