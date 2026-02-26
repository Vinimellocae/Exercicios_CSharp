// Verificar e o número digitado é multiplo de 3 e 5

Console.WriteLine("Digite algum número:");
int num = int.Parse(Console.ReadLine());

bool divisaoPor5e3 = num % 5 == 0 && num % 3 == 0;
// bool divisaoPor5e3 = num % 15 == 0; // Funciona, pois 15 é o MMC de ambos

if (divisaoPor5e3)
{
    Console.WriteLine("Divisível por 5 e 3");
}
else
{
    Console.WriteLine("NÃO é divisível por 5 e 3");
}