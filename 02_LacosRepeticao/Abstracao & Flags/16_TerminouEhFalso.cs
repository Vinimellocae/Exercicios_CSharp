bool terminou = false;

while (terminou == false)
{
    Console.WriteLine("Este laço só acaba se você digitar '0'!");
    string resposta = Console.ReadLine();

    if (resposta == "0")
    {
        terminou = true;
    }
}

Console.WriteLine("Laço encerrado!");