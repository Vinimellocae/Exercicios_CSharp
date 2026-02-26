// STOPWATCH -- Mede o tempo decorrido para executar códigos
using System.Diagnostics;

// Criar uma instância do Stopwatch
Stopwatch sw = new Stopwatch();

// START -- Inicia a contagem do tempo
sw.Start();

Console.WriteLine("Iniciando a contagem...");

// Simular um trabalho pesado com Thread.Sleep
System.Threading.Thread.Sleep(1500); // pausa 1,5 segundos

// STOP -- Para a contagem do tempo
sw.Stop();

Console.WriteLine("Parou a contagem.");

// ELAPSED -- Tempo decorrido em vários formatos
Console.WriteLine($"Tempo decorrido em milissegundos: {sw.ElapsedMilliseconds} ms");
Console.WriteLine($"Tempo decorrido total: {sw.Elapsed}");
Console.WriteLine();

// RESTART -- Reinicia a contagem (zera e começa de novo)
sw.Restart();

Console.WriteLine("Reiniciando a contagem...");

// Simular outro trabalho
System.Threading.Thread.Sleep(800);

sw.Stop();

Console.WriteLine($"Tempo decorrido após reiniciar: {sw.ElapsedMilliseconds} ms");
Console.WriteLine();

// RESET -- Zera o contador (não começa a contar automaticamente)
sw.Reset();
Console.WriteLine("Contador resetado.");

// Após reset, se quiser contar de novo, precisa chamar Start()
sw.Start();
System.Threading.Thread.Sleep(500);
sw.Stop();
Console.WriteLine($"Tempo decorrido após reset e nova contagem: {sw.ElapsedMilliseconds} ms");
