// Calculadora com Switch Case

Console.WriteLine("Digite o primeiro numero!");
double num1 = double.Parse(Console.ReadLine());

Console.WriteLine("Escolha sua operação:");
Console.WriteLine("(+) (-) (*) (/)");
string operacao = Console.ReadLine();

Console.WriteLine("Digite o segundo numero!");
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
    Console.WriteLine(num1 / num2);
    break;

    default:
    Console.WriteLine("Operação inválida!");
    break;
}
