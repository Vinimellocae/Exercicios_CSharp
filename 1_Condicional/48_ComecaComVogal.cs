// Verifique se uma palavra começa com vogal

Console.WriteLine("Escreva uma palavra");
string palavra = Console.ReadLine().ToLower();

if(string.IsNullOrWhiteSpace(palavra))
{
    Console.WriteLine("String nula ou com espaço em branco!");
    return;
}

bool ComecaComVogal = "aeiou".Contains(palavra[0]);

if (ComecaComVogal)
{
    Console.WriteLine($"A palavra ({palavra}) começa com vogal");
}
else
{
    Console.WriteLine($"NÃO começa com vogal");
}