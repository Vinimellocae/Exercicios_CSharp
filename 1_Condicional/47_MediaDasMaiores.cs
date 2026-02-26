//  Receba três notas e ignore a menor no cálculo da média

Console.WriteLine("Digite a primeira nota");
float nota1 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite a segunda nota");
float nota2 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite a terceira nota");
float nota3 = float.Parse(Console.ReadLine());

float menor;

if(nota1 <= nota2 && nota1 <= nota3)
{
    menor = nota1;
} else if(nota2 <= nota1 && nota2 <= nota3)
{
    menor = nota2;
} else
{
    menor = nota3;
}

float media = (nota1 + nota2 + nota3 - menor) / 2;

Console.WriteLine($"A média dos dois maiores números é {media}");