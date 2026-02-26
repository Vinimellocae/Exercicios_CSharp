// Verifique se o número digitado termina em 0.

Console.WriteLine("Digite um número qualquer");
int numero = int.Parse(Console.ReadLine());

if (numero % 10 == 0)
{
    Console.WriteLine("O último digito é Zero!!");
}
else
{
    Console.WriteLine("O último digito NÃO é Zero");
}
