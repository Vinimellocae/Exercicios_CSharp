bool ErroFatal = true;

do
{
    Console.WriteLine("Digite o primeiro numero");
    int num1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite o segundo numero");
    int num2 = int.Parse(Console.ReadLine());

    int soma = num1 + num2;
    Console.WriteLine(soma);
} 
while (!ErroFatal);

Console.WriteLine("Erro fatal detectado, encerrando a aplicação!");
