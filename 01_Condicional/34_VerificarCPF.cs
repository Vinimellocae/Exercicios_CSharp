// Verificar se o CPF é válido

Console.WriteLine("digite seu CPF");
nint cpf = nint.Parse(Console.ReadLine());

bool cpfValido = cpf.ToString().Length == 11;

if(cpfValido)
{
    Console.WriteLine("Seu CPF é válido!");
} else
{
    Console.WriteLine("Seu CPF é inválido");
}