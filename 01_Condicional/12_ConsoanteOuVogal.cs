// Verificar se o Caracter digitado é consoante ou vogal

Console.WriteLine("Digite alguma letra");
char caracter = char.ToLower(Console.ReadKey().KeyChar); // Lê a letra e deixa-a minúscula
Console.WriteLine();

if (!char.IsLetter(caracter)) 
{
    Console.WriteLine("Isso não é uma letra!");
}
else if ("aeiou".Contains(caracter))
{
    Console.WriteLine("Isso é uma vogal!");
}
else
{
    Console.WriteLine("Isso é uma consoante!");
} 