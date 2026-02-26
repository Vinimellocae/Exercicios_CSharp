bool ProcessoConcluido = false, finalizacao = false;
const int TEMPO_ESGOTADO = 10000;

DateTime inicio = DateTime.Now;

Console.WriteLine("Terminando de executar o processo, aguarde 10 segundos..");
while (!ProcessoConcluido)
{
    bool Conclusao = (DateTime.Now - inicio).TotalMilliseconds >= TEMPO_ESGOTADO;

    if (Conclusao)
    {
        ProcessoConcluido = true;
        continue;
    }
    else if ((DateTime.Now - inicio).TotalMilliseconds > 5000 && !finalizacao)
    {
        Console.WriteLine("Finalizando...");
        finalizacao = true;
    }
}

Console.WriteLine("Processo concluido!");