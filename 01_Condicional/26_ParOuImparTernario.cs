// Verificar se o número é par ou Impar com operador ternário

console.WriteLine("Digite um numero");
int num = int.Parse(Console.ReadLine());

Console.WriteLine(num % 2 > 0 ? "Impar" : "Par");