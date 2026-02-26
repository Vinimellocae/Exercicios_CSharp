//  Receba idade e classifique como "iniciante", "intermediário", "avançado".

Console.WriteLine("Digite sua idade");
int idade = int.Parse(Console.ReadLine());

bool iniciante = idade >= 0 && idade <= 18;
bool intermediario = idade >= 19 && idade <= 59;
bool avancado = idade >= 60 && idade <= 105;

if(iniciante)
{
    Console.WriteLine("Você esta no nível iniciante");
} else if(intermediario)
{
    Console.WriteLine("Você esta no nível intermediário");
} else if(avancado)
{
    Console.WriteLine("Você esta no nível avançado");
} else
{
    Console.WriteLine("Idade inválida");
}
