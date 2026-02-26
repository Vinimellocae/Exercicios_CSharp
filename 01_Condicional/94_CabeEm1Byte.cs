// Receba número e verifique se cabe em um byte.

Console.WriteLine("Digite um número");
int numero = int.Parse(Console.ReadLine());

bool CabeEmByte = numero >= 0  && numero <= 255;

if(CabeEmByte)
{
    Console.WriteLine($"O número {numero} cabe em um byte!");
}
else
{
    Console.WriteLine($"O número {numero} NÃO cabe em um byte!");
}