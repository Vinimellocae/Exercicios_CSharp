// Receba data e verifique se é fim de semana.

Console.WriteLine("Digite uma data (dd/mm/aaaa)");
string input = Console.ReadLine();

bool valido = DateTime.TryParse(input, out DateTime data);

if(!valido)
{
    Console.WriteLine("Data inválida!");
    return;
}

DayOfWeek dia = data.DayOfWeek;
bool fimDeSemana = dia == DayOfWeek.Saturday || dia == DayOfWeek.Sunday;

if(fimDeSemana)
{
    Console.WriteLine("Fim de semana!!");
} else
{
    Console.WriteLine("Dia útil..");
}