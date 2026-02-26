// Receba salário e calcule plano de saúde (faixa etária).

Console.WriteLine("Digite seu salário");
double salario = double.Parse(Console.ReadLine());

Console.WriteLine("Digite sua idade");
int idade = int.Parse(Console.ReadLine());

// validação de idade
if (idade > 105 || idade < 0)
{
    Console.WriteLine("Idade inválida");
    return;
} else if(salario <= 120)
{
    Console.WriteLine("Você não tem dinheiro para adquirir os planos");
    return;    
}


double variacaoIdade;

if (idade > 60) // mais velho == mais barato
{
    variacaoIdade = idade / 200.0;
}
else // <= 60
{
    variacaoIdade = idade / 100.0;
}

// salário condições
bool Plano1 = salario <= 1800;
bool Plano2 = salario > 1800 && salario <= 3000;
bool Plano3 = salario > 3000 && salario <= 5000;
bool Plano4 = salario >= 5000;

if (Plano1)
{
    double precoFinal = 120 + variacaoIdade * 120;
    Console.WriteLine($"Seu plano ficou R$: {precoFinal:F2}");
} 
else if (Plano2)
{
    double precoFinal = 180 + variacaoIdade * 180;
    Console.WriteLine($"Seu plano ficou R$: {precoFinal:F2}");
} 
else if (Plano3)
{
    double precoFinal = 220 + variacaoIdade * 220;
    Console.WriteLine($"Seu plano ficou R$: {precoFinal:F2}");
} 
else if (Plano4)
{
    double precoFinal = 300 + variacaoIdade * 300;
    Console.WriteLine($"Seu plano ficou R$: {precoFinal:F2}");
} 