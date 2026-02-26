// Verificar se uma pessoa pode dirigir (Se ela tiver 18 anos ou mais)

Console.WriteLine("Digite sua idade");
int idade = int.Parse(Console.ReadLine());

if(idade >= 18)
{
    Console.WriteLine("Pode dirigir");
} else
{
    Console.WriteLine("Não pode dirigir");
}