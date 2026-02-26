string LerEntrada() {

    Console.WriteLine("Digite Qualquer coisa (ou 'sair' para finalizar)");
    return Console.ReadLine();
}

string entrada = "";

while(entrada != "sair")
{
    entrada = LerEntrada();
} 

Console.WriteLine("Você saiu");