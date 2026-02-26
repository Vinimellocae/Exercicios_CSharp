bool LoginSucesso = false;
string senha, usuario;

do
{
    Console.WriteLine("Digite seu nome de usuário: ");
    usuario = Console.ReadLine();

    Console.WriteLine("Digite sua senha: ");
    senha = Console.ReadLine();

    if (usuario == "Robson" && senha == "123456")
    {
        LoginSucesso = true;
    }
    else
    {
        Console.WriteLine("Usuário/senha incorreto(s)");
    }
}
while (!LoginSucesso);

Console.WriteLine("Login efetuado com sucesso!");