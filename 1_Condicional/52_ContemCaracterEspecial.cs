// Verifique se uma senha contém caractere especial.

Console.WriteLine("Escreva uma palavra");
string senha = Console.ReadLine().ToLower();

if(string.IsNullOrWhiteSpace(senha))
{
    Console.WriteLine("String nula ou com espaço em branco!");
    return;
}

bool ExisteCaracterEspecial = senha.Any(c => !char.IsLetterOrDigit(c));

if(ExisteCaracterEspecial)
{
    Console.WriteLine("Possui caracter especial!");
} else
{
    Console.WriteLine("NÃO possui caracter especial!");
}
