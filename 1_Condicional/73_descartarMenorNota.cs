// Receba 4 notas e descarte a menor.

Console.WriteLine("Digite a primeira nota");
double nota1 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a segunda nota");
double nota2 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a tercira nota");
double nota3 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a quarta nota");
double nota4 = double.Parse(Console.ReadLine());

double[] lista = {nota1, nota2, nota3, nota4};

Array.Sort(lista);

double menor = lista[0];

double soma = nota1 + nota2 + nota3 + nota4 - menor;

Console.WriteLine($"A soma das notas com a menor descartada é {soma}");