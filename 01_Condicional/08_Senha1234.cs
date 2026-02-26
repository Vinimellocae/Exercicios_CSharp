// Dizer se o usuário acertou ou errou a senha!

Console.WriteLine("Digite uma senha de 4 digitos");
int senha = int.Parse(Console.ReadLine());

int senhaCorreta = 1234;
Console.WriteLine(senha == senhaCorreta ? "Acertou a senha!" : "Senha incorreta!");