// Verificar se um número é positivo ou negativo

Console.WriteLine("digite um numero");
float num = float.Parse(Console.ReadLine());

if (num == 0)
{
    Console.WriteLine("O número é zero!");
    return;
}

Console.WriteLine(num > 0 ? "Número positivo" : "Negativo");