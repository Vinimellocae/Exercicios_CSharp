// Verificar se a palavra é um palindromo

Console.WriteLine("Digite uma palavra");
string palavra = Console.ReadLine();
var reverse = new string(palavra.Reverse().ToArray());

var isPalin = palavra == reverse;

if (isPalin)
{
    Console.WriteLine("Esta palavra é um palindromo");
}
else
{
    Console.WriteLine("Esta palavra NÃO é um palindromo");
}