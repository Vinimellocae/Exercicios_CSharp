Console.WriteLine("Digite um número");
int num = int.Parse(Console.ReadLine());

Console.WriteLine($"Tabuada do {num}");

for(int i = 0; i <= 10; i++)
{
    int resultado = num * i;
    Console.WriteLine($"{num} * {i} = {resultado}");    
}
