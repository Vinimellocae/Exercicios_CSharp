// Verificar se o valor digitado é um digito

Console.WriteLine("Digite um caracter");
char digito = Console.ReadKey().KeyChar;
Console.WriteLine();

Console.WriteLine(char.IsDigit(digito) ? "É um dígito" : "Não é um digito");