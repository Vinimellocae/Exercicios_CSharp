// Receba hora e mostre "Bom dia", "Boa tarde" ou "Boa noite"

Console.WriteLine("Digite o horário");
string input = Console.ReadLine();

bool conversao = int.TryParse(input, out int hora);

if (!conversao)
{
    Console.WriteLine("Digite um horário inteiro válido");
    return;
}

bool bomDia = hora >= 5 && hora < 12;
bool boaTarde = hora >= 12 && hora < 19;
bool boaNoite = (hora >= 19 && hora <= 23) || (hora >= 0 && hora < 5);

if (bomDia)
{
    Console.WriteLine("Bom Dia!");
}
else if (boaTarde)
{
    Console.WriteLine("Boa Tarde!");
}
else if (boaNoite)
{
    Console.WriteLine("Boa Noite!");
}
else
{
    Console.WriteLine("Digite um horário inteiro válido");
}
