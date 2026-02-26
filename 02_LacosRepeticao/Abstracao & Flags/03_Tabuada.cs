Console.WriteLine("Digite um numero para saber a tabuada:");
int numero = int.Parse(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("Tabuada do 1 ao 10:");
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{i} * {numero} = {i * numero}");
}