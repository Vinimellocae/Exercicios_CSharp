// Verificar se a letra esta maiuscula ou minuscula

Console.WriteLine("Digite um caracter");
char letra = Console.ReadKey().KeyChar;
Console.WriteLine();

if(char.IsLetter(letra))
{
    if(char.IsUpper(letra))
    {
        Console.WriteLine("A letra está maiúscula");
    } 
    else
    {
        Console.WriteLine("A letra está minúscula"); 
    }
} 
else
{
    Console.WriteLine("Não é uma letra!"); 
    return;
}