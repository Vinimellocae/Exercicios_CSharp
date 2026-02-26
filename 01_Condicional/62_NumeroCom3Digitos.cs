// Verifique se um número tem 3 dígitos.

Console.WriteLine("Digite um número qualquer");
int numero = int.Parse(Console.ReadLine());

string numeroSring = numero.ToString();

if (numeroSring.Length == 3)
{
    Console.WriteLine($"O número {numero} possui 3 digitos");
}
else
{
    Console.WriteLine($"O número {numero} NÃO possui 3 digitos");
}

