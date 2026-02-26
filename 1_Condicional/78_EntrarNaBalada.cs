// Receba idade e mostre se pode entrar em balada (+18)

Console.WriteLine("Digite sua idade");
int idade = int.Parse(Console.ReadLine());

bool podeEntrar = idade >= 18;

if(idade > 105 || idade < 0)
{
    Console.WriteLine("idade Inválida");
    return;
}

Console.WriteLine(podeEntrar ? "Pode entrar na balada" : "Não pode entrar na balada");