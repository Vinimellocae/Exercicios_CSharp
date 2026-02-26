const int SOMA_LIMITE = 200;
int soma = 0;

do
{
    Console.WriteLine("Digite um número");
    int numero = int.Parse(Console.ReadLine());
    soma += numero;
    Console.WriteLine($"Total: {soma}");
}
while(soma <= SOMA_LIMITE);

Console.WriteLine("A soma ultrapassou o limite!");