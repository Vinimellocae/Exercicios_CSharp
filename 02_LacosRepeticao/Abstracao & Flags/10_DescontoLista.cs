List<double> Precos = new List<double> { 11.99, 46.90, 199.99, 299.99 };
int i = 0;
Precos.ForEach(preco => Console.WriteLine($"Produto {++i} com desconto: {preco * 0.80:F2}")); // 20% de desconto
