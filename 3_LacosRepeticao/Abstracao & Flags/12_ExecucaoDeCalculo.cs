int soma = 0, num1, num2;

do
{
    soma = 0;

    Console.WriteLine("Digite o valor do primeiro numero");
    num1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite o valor do segundo numero");
    num2 = int.Parse(Console.ReadLine());

    soma = num1 + num2;

    Console.WriteLine($"soma = {soma}");
}
while(soma > 20);

Console.WriteLine("Soma limite atingida!");