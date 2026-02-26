// Receba nota e dê mensagem de acordo com faixa (if-elseif).

Console.WriteLine("Digite sua nota");
double nota = double.Parse(Console.ReadLine());

bool alta = nota >= 8;
bool media = nota >= 6;
bool baixa = nota < 6;
bool invalida = nota > 10 || nota < 0;

if(invalida)
{
    Console.WriteLine("Nota inválida!");
} 
else if(alta)
{
    Console.WriteLine("Nota Alta!!");
}
else if(media)
{
    Console.WriteLine("Nota Média!!");
}
else if(baixa)
{
    Console.WriteLine("Nota Baixa!!");
}