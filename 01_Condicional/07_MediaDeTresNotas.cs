// Verificar média de 3 notas e dizer se foi aprovado, reprovado ou se ficou de
// recuperação

Console.WriteLine("Digite a primeira nota");
float nota1 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite a segunda nota");
float nota2 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite a terceira nota");
float nota3 = float.Parse(Console.ReadLine());

float media = (nota1 + nota2 + nota3) / 3;

if (media >= 6)
{
    Console.WriteLine("Passou!");
    return;
}
else if (media >= 5)
{
    Console.WriteLine("Recuperação!");
    return;
}
else
{
    Console.WriteLine("Reprovado!");
}