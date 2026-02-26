const int LIMITE_MAXIMO = 100;
int soma = 0;

do
{
    Console.WriteLine("Digite um numero");
    int num = int.Parse(Console.ReadLine());
    soma += num; 
    Console.WriteLine($"Total: {soma}");
} 
while(soma <= 100); 

Console.WriteLine("Excedeu o limite!");