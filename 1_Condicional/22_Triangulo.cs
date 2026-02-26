// Verificar se três lados formam um triângulo

Console.WriteLine("Digite o primeiro lado:");
float lado1 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo lado:");
float lado2 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite o terceiro lado:");
float lado3 = float.Parse(Console.ReadLine());

bool condicao1 = lado1 + lado2 > lado3;
bool condicao2 = lado1 + lado3 > lado2;
bool condicao3 = lado3 + lado2 > lado1;

if (condicao1 && condicao2 && condicao3)
{
} else
{
    Console.WriteLine("NÃO é um triâgulo!");
}