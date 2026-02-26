string resposta = "a";

do
{
    Console.WriteLine("Vou repetir esta frase até você digitar 'sair'!");
    resposta = Console.ReadLine().ToLower();
}
while(resposta != "sair");

Console.WriteLine("Saida executada com sucesso!");