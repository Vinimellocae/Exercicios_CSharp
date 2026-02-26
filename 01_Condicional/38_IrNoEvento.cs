// Verificar se pode ir no evento (idade >= 21)

Console.WriteLine("Digite sua idade");
int idade = int.Parse(Console.ReadLine());

bool dentroDaFaixa = idade >= 21;
bool idadeInvalida = idade >= 105 || idade < 0;

if(idadeInvalida)
{
    Console.WriteLine("Idade inválida!");
    return;
}

if(dentroDaFaixa)
{
    Console.WriteLine("Você pode entrar no evento!");
} else
{
    Console.WriteLine("Você não tem idade para entrar no evento");
}
