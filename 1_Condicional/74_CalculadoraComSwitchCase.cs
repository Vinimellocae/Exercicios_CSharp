// Use switch para operações matemáticas (+, -, *, /).

Console.WriteLine("Calculadora");
Console.WriteLine("Primeiro número");
double num1 = double.Parse(Console.ReadLine());

Console.WriteLine("Operação");
string operacao = Console.ReadLine();

Console.WriteLine("Segundo número");
double num2 = double.Parse(Console.ReadLine());

switch(operacao)
{
    case "+":
    Console.WriteLine(num1 + num2);
    break;

    case "-":
    Console.WriteLine(num1 - num2);
    break;

    case "*":
    Console.WriteLine(num1 * num2);
    break;

    case "/":
    if(num2 == 0)
        {
        Console.WriteLine("Divisão por zero!");
        return;    
        }
    Console.WriteLine($"Total: {num1 / num2}");
    break;

    default:
    Console.WriteLine("Operação inválida!");
    break;
}
