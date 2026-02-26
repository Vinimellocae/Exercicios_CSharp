// Receba string e verifique se tem espaços no início ou fim.

Console.WriteLine("Digite qualquer coisa");
string palavra = Console.ReadLine();

bool espacoBranco1 = char.IsWhiteSpace(palavra[0]); 
bool espacoBranco2 = char.IsWhiteSpace(palavra[palavra.Length - 1]); 

if(espacoBranco1 && espacoBranco2)
{
    Console.WriteLine("A palavra começa e termina com Espaço em branco");
} 
else if(espacoBranco1)
{
    Console.WriteLine("A palavra começa com Espaço em branco");
}
else if(espacoBranco2)
{
    Console.WriteLine("A palavra termina com Espaço em branco");
} else
{
    Console.WriteLine("A palavra NÃO começa e NEM termina com Espaço em branco");
}