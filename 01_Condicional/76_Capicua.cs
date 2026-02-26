// Verifique se um número é capicua (igual ao reverso)

Console.WriteLine("Digite um número");
int numero = int.Parse(Console.ReadLine());

string num = numero.ToString();
var reverse = new string (num.Reverse().ToArray());

bool capicua = num == reverse;

Console.WriteLine(capicua ? $"O número {numero} é capicua" : $"O número {numero} NÃO é capicua");