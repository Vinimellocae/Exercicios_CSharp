string LerEntrada() {

    Console.WriteLine("Digite a senha");
    return Console.ReadLine();
}

bool senhaCorreta = false;
string senha;

while(!senhaCorreta)
{
    senha = LerEntrada();

    if(senha == "12345678")
    {
        senhaCorreta = true;
    }
    else
    {
        Console.WriteLine("Senha incorreta");
    }
}

Console.WriteLine("Acertou a senha!");