// Receba duas strings e verifique se são iguais ignorando 
// maiúsculas/minúsculas

Console.WriteLine("Escreva a primeira string");
string stringo1 = Console.ReadLine().ToUpper();

Console.WriteLine("Escreva a primeira string");
string stringo2 = Console.ReadLine().ToUpper();

bool StringsIguais = stringo1 == stringo2;

Console.WriteLine(StringsIguais ? "As strings são IGUAIS" : "As strings são DIFERENTES");