// Classificar triângulos de acordo com o valor dos lados

Console.WriteLine("Digite o primeiro lado:");
float lado1 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo lado:");
float lado2 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite o terceiro lado:");
float lado3 = float.Parse(Console.ReadLine());

// Classificação dos triângulos
bool escaleno = lado1 != lado2 && lado1 != lado3 && lado2 != lado3;
bool equilatero = lado1 == lado2 && lado1 == lado3 && lado2 == lado3;

if (escaleno)
{
    Console.WriteLine("É um triâgulo Escaleno!");
}
else if (equilatero)
{
    Console.WriteLine("É um triâgulo Equilátero!");
}
else
{
    Console.WriteLine("É um triâgulo Isósceles!");
}
