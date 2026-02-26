// Aplicar um desconto de 10% caso a compra custe mais de 100 reais

Console.WriteLine("Quantos reais deu sua compra?");
float valor = float.Parse(Console.ReadLine());

if(valor >= 100)
{
    float valorCDesconto = valor - (float)(valor * 0.1); 
    Console.WriteLine("Você recebeu um desconto de 10%!");
    Console.WriteLine($"Sua compra ficou {valorCDesconto} reais!");
} else
{
    Console.WriteLine($"Sua compra ficou {valor} reais");
}