// Use switch para classificar um número de 1 a 7 em dia da semana.

Console.WriteLine("Digite um número");
int diaDaSemana = int.Parse(Console.ReadLine());

switch(diaDaSemana)
{
    case 1:
    Console.WriteLine("Domingo");
    break;

    case 2:
    Console.WriteLine("Segunda");
    break;

    case 3:
    Console.WriteLine("Terça");
    break;

    case 4:
    Console.WriteLine("Quarta");
    break;

    case 5:
    Console.WriteLine("Quinta");
    break;

    case 6:
    Console.WriteLine("Sexta");
    break;

    case 7:
    Console.WriteLine("Sábado");
    break;

    default:
    Console.WriteLine("Dia da semana inválido");
    break;
}