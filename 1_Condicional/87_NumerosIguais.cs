// Receba dois números e mostre se são iguais.

Console.WriteLine("Digite o primeiro numero");
int numero1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo numero");
int numero2 = int.Parse(Console.ReadLine());

bool iguais = numero1 == numero2;

Console.WriteLine(iguais ? "Os números são iguais" : "Os números são diferentes");
