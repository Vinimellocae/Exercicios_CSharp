bool ConexaoEstablelecida = false;

Console.WriteLine("Verificando se você não é um robô!");

while(!ConexaoEstablelecida)
{
    Console.WriteLine("Digite o código na imagem:");
    Console.WriteLine("12$FsarU8");
    string codigo = Console.ReadLine();

    if(codigo == "12$FsarU8")
    {
        ConexaoEstablelecida = true;
        break;
    }
    
    Console.WriteLine("Erro, tente novamente!");

}

Console.WriteLine("Conexão estabelecida!");