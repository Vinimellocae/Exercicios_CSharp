// Verificar se sua senha possui 8 digitos

Console.WriteLine("Digite sua senha");
string senha = Console.ReadLine();

bool SenhaDe8Digitos = senha.Length == 8;

if(SenhaDe8Digitos)
{
    Console.WriteLine("Sua senha possui 8 digitos");
} else
{
    Console.WriteLine("Sua senha NÃO possui 8 digitos"); 
}