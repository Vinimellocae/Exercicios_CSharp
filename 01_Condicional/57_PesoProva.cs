//  Calcule nota final considerando peso em duas provas

Console.WriteLine("Digite a nota da primeira prova (Peso 1)");
float nota1 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite a nota da segunda prova (Peso 2)");
float nota2 = float.Parse(Console.ReadLine());

if(nota1 > 10 || nota2 > 10)
{
    Console.WriteLine("Nota inválida!");
    return;
}

float media = (nota1 + nota2 * 2) / 3; 
bool estaNaMedia = media >= 6;


if(estaNaMedia)
{
    Console.WriteLine($"Você está na média com nota {media}");
} else
{
    Console.WriteLine($"Você NÃO está na média, pois tirou {media}");
}
