bool continuarProcesso = true;
int i = 0;

while (continuarProcesso)
{
    Console.WriteLine($"Processo {++i}");

    Console.WriteLine("Deseja continuar com o processo?");
    Console.WriteLine("Aperte qualquer tecla para continuar ou aperte (n) para parar");
    string parar = Console.ReadLine();

    if (parar == "n")
    {
        continuarProcesso = false;
    }
}

Console.WriteLine("Processo encerrado");