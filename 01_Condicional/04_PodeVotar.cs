// Verificar se uma pessoa pode votar (Se ela tiver 16 anos ou mais)

Console.WriteLine("Digite sua idade");
int idade = int.Parse(Console.ReadLine());

if(idade >= 16)
{
    Console.WriteLine("Pode votar");
} else
{
    Console.WriteLine("Não pode votar");
}