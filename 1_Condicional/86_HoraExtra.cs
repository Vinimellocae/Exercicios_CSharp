// Receba número de horas trabalhadas e calcule hora extra

Console.WriteLine("Digite quantas horas extras você fez:");
int HorasExtras = int.Parse(Console.ReadLine());

Console.WriteLine("Digite seu salário:");
int salario = int.Parse(Console.ReadLine());

double ValorHora = salario / 220.0;

double salarioNovo = (HorasExtras * ValorHora) + salario;

Console.WriteLine($"O seu salário esse mês foi de R$:{salarioNovo:F2}");
