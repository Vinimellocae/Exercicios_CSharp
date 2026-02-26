// Verifique se o caractere digitado é espaço

Console.WriteLine("Digite alguma coisa");
char caracter = Console.ReadKey().KeyChar;

bool espacoBranco = char.IsWhiteSpace(caracter);

if (espacoBranco)
{
    Console.WriteLine("Há um espaço em branco");
}
else
{
    Console.WriteLine("Não há espaços em branco");
}