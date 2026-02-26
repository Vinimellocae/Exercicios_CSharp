// Receba altura e sexo, calcule peso ideal.

Console.WriteLine("Digite sua altura em cm");
double altura = double.Parse(Console.ReadLine());

altura = altura / 100;

Console.WriteLine("Digite o seu sexo (Homem/Mulher)");
string sexo = Console.ReadLine().ToLower();

bool condicao = sexo == "homem" || sexo == "mulher";

if (condicao)
{
    if (sexo == "mulher")
    {
        double pesoIdeal = (62.1 * altura) - 44.7;
        Console.WriteLine($"O seu peso ideal é {pesoIdeal:F2} kg");
        return;
    }
    else if (sexo == "homem")
    {
        double pesoIdeal = (72.7 * altura) - 58;
        Console.WriteLine($"O seu peso ideal é {pesoIdeal:F2} kg");
    }
} else
{
    Console.WriteLine("Erro: Você digitou algo errado em 'sexo' ");
}