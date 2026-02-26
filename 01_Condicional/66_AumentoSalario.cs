// Calcule aumento de salário: se < 1500 => 20%, senão 10%

Console.WriteLine("Digite seu salário");
double salario = double.Parse(Console.ReadLine());

bool aumento10 = salario > 1500;
bool aumento20 = salario < 1500 && salario > 0;

if(aumento10)
{
    Console.WriteLine($"Com o aumento, seu salário será de R$:{salario * 1.1}");
} else if (aumento20)
{
    Console.WriteLine($"Com o aumento, seu salário será de R$:{salario * 1.2}");
} else
{
    Console.WriteLine("Valor inválido!");
}