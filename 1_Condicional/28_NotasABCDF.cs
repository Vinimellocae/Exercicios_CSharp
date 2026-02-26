// Exibir notas em formato de letras

Console.WriteLine("Digite sua nota");
float nota = float.Parse(Console.ReadLine());

bool A = nota == 10; 
bool B = nota >= 8; 
bool C = nota >= 7; 
bool D = nota >= 6;

if(A)
{
    Console.WriteLine("Você tirou A!!");
} else if(B)
{
    Console.WriteLine("Você tirou B!!");
} else if(C)
{
    Console.WriteLine("Você tirou C!!");
} else if(D)
{
    Console.WriteLine("Você tirou D!!");
} else
{
    Console.WriteLine("Você tirou F");
}
