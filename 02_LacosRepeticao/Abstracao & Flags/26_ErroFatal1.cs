bool ErroFatal = false;
int i = 1;

while(!ErroFatal)
{
    if(i == 40)
    {
        Console.WriteLine($"Erro fatal, não pode imprimir {i}");
        ErroFatal = true;
        continue;
    }    

    Console.WriteLine(i);
    i++;
}