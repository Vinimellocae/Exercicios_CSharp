// Verifique se o mês informado é férias (dezembro, janeiro, julho).

Console.WriteLine("Digite o mês");
string mes = Console.ReadLine().ToLower();

string[] ferias = {"janeiro", "dezembro", "julho"};

string[] NaoEhferias = {"fevereiro", "março", "abril", "maio", "junho", "agosto", "setembro", "outubro", "novembro"};

if(ferias.Contains(mes))
{
    Console.WriteLine("Este mês é férias!!");
} else if(NaoEhferias.Contains(mes))
{
    Console.WriteLine("Esse mês não é férias");
} else
{
    Console.WriteLine("Erro de digitação!");
}