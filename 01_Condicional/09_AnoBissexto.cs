// Verificar se o Ano digitado é bissexto

Console.WriteLine("Digite um ano");
int ano = int.Parse(Console.ReadLine());

if ((ano % 4) == 0)
{
    Console.WriteLine("Este ano é bissexto!");
}
else
{
    Console.WriteLine("Este ano NÃO é bissexto!");
}