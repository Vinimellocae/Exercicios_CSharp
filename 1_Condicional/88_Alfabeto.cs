//  Receba uma letra e verifique se é do alfabeto

Console.WriteLine("Digite uma letra");
char caracter = char.ToLower(Console.ReadKey().KeyChar);
Console.WriteLine();

if ("abcdefghijklmnopqrstuvwxyz".Contains(caracter))
{
    Console.WriteLine("Pertence ao alfabeto!");
}
else
{
    Console.WriteLine("NÃO pertence ao alfabeto!");
}
