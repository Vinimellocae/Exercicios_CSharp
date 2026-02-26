// Receba idade e mostre se precisa de autorização dos pais.

Console.WriteLine("Quantos anos você tem?");
int idade = int.Parse(Console.ReadLine());

bool precisaDeAutorizacao = idade < 16;

Console.WriteLine(precisaDeAutorizacao ? "Para subir na montanha russa é so com autorização dos pais!" : "Pode entrar no brinquedo!");