// Verificar qual dos dois números é o maior

Console.WriteLine("digite o primeiro numero");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("digite o segundo numero");
int num2 = int.Parse(Console.ReadLine());

if (num1 == num2)
{
    Console.WriteLine("Os números são iguais");
    return;
}

if(num1 > num2)
{
    Console.WriteLine($"O maior número é o número {num1}");
}
else
{
    Console.WriteLine($"O maior número é o número {num2}");
}