using System;
using System.Globalization;

// Receba dois horários e mostre qual é maior.

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o primeiro horário (HH:mm):");
        string horario1Str = Console.ReadLine();

        Console.WriteLine("Digite o segundo horário (HH:mm):");
        string horario2Str = Console.ReadLine();

        string formato = "HH:mm";

        bool valido1 = DateTime.TryParseExact(horario1Str, formato, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime horario1);
        bool valido2 = DateTime.TryParseExact(horario2Str, formato, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime horario2);

        if (!valido1 || !valido2)
        {
            Console.WriteLine("Erro: horário inválido! Use o formato HH:mm (ex: 14:30).");
            return;
        }

        if (horario1.TimeOfDay > horario2.TimeOfDay)
        {
            Console.WriteLine($"O primeiro horário ({horario1:HH:mm}) é maior.");
        }
        else if (horario2.TimeOfDay > horario1.TimeOfDay)
        {
            Console.WriteLine($"O segundo horário ({horario2:HH:mm}) é maior.");
        }
        else
        {
            Console.WriteLine("Os horários são iguais.");
        }
    }
}
