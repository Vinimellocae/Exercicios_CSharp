// Verificar se a string possui um '@'

Console.WriteLine("Digite seu E-mail");
string email = Console.ReadLine();

if ("@".Contains(email))
{
    Console.WriteLine("Email válido!");
}
else
{
    Console.WriteLine("Email inválido!");
}