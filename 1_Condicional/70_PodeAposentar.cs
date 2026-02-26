// Receba idade e verifique se pode se aposentar (homem 65, mulher 62).

Console.WriteLine("Digite sua idade");
int idade = int.Parse(Console.ReadLine());

Console.WriteLine("Digite seu sexo (homem/mulher)");
string sexo = Console.ReadLine().ToLower();

if(idade >= 105 || idade < 0)
{
    Console.WriteLine("Idade inválida");
    return;
} 

switch (sexo)
{
    case "homem":
        if (idade > 65)
        {
            Console.WriteLine("Pode aposentar");
        }
        else
        {
            Console.WriteLine("Não tem idade para aposentar");
        }
    break;

    case "mulher":
        if (idade > 62)
        {
            Console.WriteLine("Pode aposentar");
        }
        else
        {
            Console.WriteLine("Não tem idade para aposentar");
        }
    break;

    default:
    Console.WriteLine("Digite seu sexo corretamente");
    break;
}