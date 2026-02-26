// Receba temperatura em Fahrenheit e classifique.

Console.WriteLine("Digite a temperatura em F°");
int temperatura = int.Parse(Console.ReadLine());

bool quente = temperatura > 68;
bool frio = temperatura < 50 ;

if (quente)
{
    Console.WriteLine("Está calor!");
}
else if(frio)
{
    Console.WriteLine("Está frio!");
} else
{
    Console.WriteLine("Está um clima agradável!");
}