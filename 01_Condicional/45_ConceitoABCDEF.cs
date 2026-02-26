// Receba nota e transforme em conceito

Console.WriteLine("Digite um numero decimal ou inteiro");
int nota = int.Parse(Console.ReadLine());

bool A = nota >= 90;
bool B = nota >= 80;
bool C = nota >= 70;
bool D = nota >= 60;
bool E = nota >= 50;
bool F = nota >= 0;

bool notaInvalida = nota > 100 || nota < 0;

if(notaInvalida)
{
    Console.WriteLine("Nota inválida");
    return;
}

if(A)
{
    Console.WriteLine("Você tirou A");
} 
else if(B)
{
    Console.WriteLine("Você tirou B");
} 
else if(C)
{
    Console.WriteLine("Você tirou C");
} 
else if(D)
{
    Console.WriteLine("Você tirou D");
} 
else if(E)
{
    Console.WriteLine("Você tirou E");
} 
else if (F)
{
    Console.WriteLine("Você tirou F");
}