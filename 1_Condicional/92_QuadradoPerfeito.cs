// Receba número e verifique se é quadrado perfeito.

Console.WriteLine("Digite um número");
int numero = int.Parse(Console.ReadLine());

bool quadradoPerfeito = Math.Sqrt(numero) % 1 == 0;

Console.WriteLine(quadradoPerfeito ? $"O número {numero} é um quadrado perfeito!" : "Não é quadrado perfeito");