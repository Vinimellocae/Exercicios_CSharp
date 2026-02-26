bool CPF_Valido = false;

do
{
    Console.WriteLine("Digite seu CPF");
    string CPF = Console.ReadLine();

    if (CPF.Length == 11 && CPF.All(char.IsDigit))
    {
        Console.WriteLine("Cpf Válido!");
        CPF_Valido = true;
    }
    else
    {
        Console.WriteLine("Cpf Inválido");
    }
}
while (!CPF_Valido);