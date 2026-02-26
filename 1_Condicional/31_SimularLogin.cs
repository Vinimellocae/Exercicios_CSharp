// Simular um login

Console.WriteLine("Seu E-mail");
string email = Console.ReadLine();

Console.WriteLine("Digite sua senha");
string senha = Console.ReadLine();

bool emailCorreto = email == "vinicius@gmail.com";
bool senhaCorreta = senha == "12345678";



if(emailCorreto && senhaCorreta)
{
    Console.WriteLine("Login efetuado com sucesso");
} else
{
    Console.WriteLine("E-mail ou senha incorretos");
}