// Receba salário e calcule faixa de imposto (simulação).

Console.WriteLine("Digite seu salário");
double salario = double.Parse(Console.ReadLine());

bool isento = salario <= 2000 && salario > 0;
bool percent10 = salario > 2000 && salario <= 4000;
bool percent20 = salario > 4000 && salario <= 6000;
bool percent30 = salario > 6000;

if(isento)
{
    Console.WriteLine("Você não precisa pagar imposto");
} else if(percent10)
{
    double imposto = salario * 0.1;
    Console.WriteLine($"Você precisa pagar R$: {imposto} de imposto");
} else if(percent20)
{
    double imposto = salario * 0.2;
    Console.WriteLine($"Você precisa pagar R$: {imposto} de imposto");
} else if(percent30)
{
    double imposto = salario * 0.3;
    Console.WriteLine($"Você precisa pagar R$: {imposto} de imposto");
} else
{
    Console.WriteLine("Valor inválido!!");
}