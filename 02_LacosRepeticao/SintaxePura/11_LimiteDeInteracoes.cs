const int LIMITE_INTERACOES = 6;
int QtdeInteracoes = 1;

while(QtdeInteracoes <= LIMITE_INTERACOES)
{
    Console.WriteLine("Escreva qualquer coisa");
    Console.WriteLine(Console.ReadLine());
    QtdeInteracoes += 1;

}

Console.WriteLine("Seu número de interções ultrapassou o limite.");