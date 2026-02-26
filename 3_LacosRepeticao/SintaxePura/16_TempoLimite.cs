const int TEMPO_LIMITE = 5000; // 5 segundos

DateTime inicio = DateTime.Now;
bool condicaoParada = true;

while (condicaoParada)
{
    Console.WriteLine("Executando");
    condicaoParada = (DateTime.Now - inicio).TotalMilliseconds < TEMPO_LIMITE;
}

Console.WriteLine("Limite de Tempo Estourado!");