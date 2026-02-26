// Receba idade e mostre faixa escolar.

Console.WriteLine("Digite sua idade");
int idade = int.Parse(Console.ReadLine());

bool creche =  idade <= 2;
bool maternal = idade <= 5 && idade >= 3;
bool fund1 = idade <= 10 && idade >= 6;
bool fund2 = idade <= 14 && idade >= 11;
bool ensinoMedio = idade <= 18 && idade >= 15;

if(idade < 0 || idade > 105)
{
    Console.WriteLine("idade inválida");
    return;
}

if(creche) 
{
    Console.WriteLine("Você provavelmente está na creche");    
}
else if(maternal)
{
    Console.WriteLine("Você provavelmente está no maternal");
}
else if(fund1) 
{
    Console.WriteLine("Você provavelmente está no Fundamental 1");
}
else if(fund2) 
{
    Console.WriteLine("Você provavelmente está no Fundamental 2");
}
else if(ensinoMedio) 
{
    Console.WriteLine("Você provavelmente está no Ensino Médio");
} else
{
    Console.WriteLine("Você já teminou a escola");
}