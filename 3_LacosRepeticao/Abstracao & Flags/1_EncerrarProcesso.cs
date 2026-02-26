bool EncerrarProcesso = false;
int numero = 0;

while(!EncerrarProcesso)
{

    if(numero == 100)
    {
        EncerrarProcesso = true;
        break;
    }

    Console.WriteLine(numero += 1);
    //-------------------------------------
}

Console.WriteLine("Processo Encerrado!");