// Receba valor e verifique se pode ser dividido em 3 parcelas iguais

Console.WriteLine("Digite o valor da sua compra");
int valor = int.Parse(Console.ReadLine());

bool ParcelasIguais = valor % 3 == 0;

if(valor <= 0)
{
    Console.WriteLine($"Digite um valor válido!");
}

if(ParcelasIguais)
{
    Console.WriteLine($"{valor} pode ser dividido entre 3 parcelas!");
} else
{
    Console.WriteLine($"{valor} NÃO pode ser dividido entre 3 parcelas!");
}