// Oferecer aumento no salário de acordo com o valor do salário

Console.WriteLine("Digite o seu salário");
double salario = double.Parse(Console.ReadLine());

bool aumento20 = salario < 2000;

if(aumento20)
{
    double novoSalario = salario + (salario * 0.2);
    Console.WriteLine($"Seu salário é de {novoSalario}");
} else
{
    double novoSalario = salario + (salario * 0.1);
    Console.WriteLine($"Seu salário é de {novoSalario}");
}