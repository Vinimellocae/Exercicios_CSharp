bool entradaValida = false;
string senha;

do
{
    Console.WriteLine("Digite sua senha: ");
    senha = Console.ReadLine();

    if (senha == "123456")
    {
        entradaValida = true;
    }
    else
    {
        Console.WriteLine("Senha incorreta, tente novamente!");
    }
}
while (!entradaValida);

Console.WriteLine("Login efetuado com sucesso!");