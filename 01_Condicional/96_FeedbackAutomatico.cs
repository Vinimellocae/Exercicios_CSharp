// Receba nota e mostre feedback automático.

Console.WriteLine("Digite sua nota");
double nota = double.Parse(Console.ReadLine());

bool Erro = nota > 10 || nota < 0;

if(Erro)
{
    Console.WriteLine("Nota inválida! Escolha entre 0 e 10");
    return;
}

bool Excelente = nota == 10;
bool Otimo = nota >= 8 && nota < 10;
bool Ok = nota >= 6 && nota < 8;

if(Excelente)
{
    Console.WriteLine("Nota excelente, muito bem!");
}
else if(Otimo)
{
    Console.WriteLine("Nota ótima, bom trabalho!");
}
else if(Ok)
{
    Console.WriteLine("Nota ok, pode melhorar!");
}
else
{
    Console.WriteLine("Pelo jeito alguém não etudou para essa prova!");
}