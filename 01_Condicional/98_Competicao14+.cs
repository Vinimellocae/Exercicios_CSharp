// Receba idade e verifique se pode participar de competição(14+)

Console.WriteLine("Digite sua idade");
int idade = int.Parse(Console.ReadLine());

bool podeParticipar = idade >= 14;

if(idade < 0 || idade > 105)
{
    Console.WriteLine("Idade inválida");
    return;
}

if(podeParticipar)
{
    Console.WriteLine("Pode participar da competição");
} else
{
    Console.WriteLine("NÃO pode participar da competição");
}