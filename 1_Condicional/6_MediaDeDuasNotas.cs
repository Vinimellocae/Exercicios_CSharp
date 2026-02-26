// Verificar média de 2 notas e dizer se foi aprovado ou reprovado

Console.WriteLine("Digite a primeira nota");
float nota1 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite a segunda nota");
float nota2 = float.Parse(Console.ReadLine());

float media = (nota1 + nota2) / 2;

Console.WriteLine(media >= 6 ? "Aprovado!" : "Reprovado");