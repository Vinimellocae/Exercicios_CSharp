List<int> precos = new List<int> {15, 39, 450, 31, 67, 42, 21, 11};

int soma = 0;
int somaMelhor = precos.Sum();

foreach(var preco in precos)
{
    soma += preco;    
}

Console.WriteLine($"Sua compra deu R$:{soma},00 reais!");
Console.WriteLine($"Sua compra deu R$:{somaMelhor},00 reais!");