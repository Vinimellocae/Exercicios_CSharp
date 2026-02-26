// Classificar horas em dia, tarde e noite

Console.WriteLine("Digite o horário");
float horas = float.Parse(Console.ReadLine());

bool manha = horas >= 6 && horas <= 12;
bool tarde = horas >= 12 && horas <= 18;
bool noite = horas >= 18 || horas <= 6;

if(manha)
{
    Console.WriteLine("Agora é de manhã");
} else if(tarde)
{
    Console.WriteLine("Agora é de tarde");
} else if(noite)
{
    Console.WriteLine("Agora é de noite");
}