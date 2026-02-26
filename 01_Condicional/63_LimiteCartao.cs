// Receba valor e verifique se cabe no cartão (limite)

Console.WriteLine("Digite o valor da sua compra");
double capital = double.Parse(Console.ReadLine());

bool erro = capital <= 0;

if (erro)
{
    Console.WriteLine("Valor inválido!");
    return;
}

bool LimiteCartao = capital >= 3000;

Console.WriteLine(LimiteCartao ? "Ultrapassou o limite do cartão!" : "Compra efetuada com sucesso!");