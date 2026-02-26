// Receba temperatura em °C e classifique (frio, agradável, quente).

Console.WriteLine("Digite a temperatura em C°");
double temperatura = double.Parse(Console.ReadLine());

bool calor = temperatura > 25;
bool frio = temperatura < 19;

if(calor)
{
    Console.WriteLine("Está quente");
} else if(frio)
{
    Console.WriteLine("Está frio");
} else
{
    Console.WriteLine("Está agradável");
}