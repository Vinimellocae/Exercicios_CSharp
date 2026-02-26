// Receba string e verifique se termina com ".com".

Console.WriteLine("Digite um site");
string site = Console.ReadLine();

bool Termina = site.EndsWith(".com");

if(Termina)
{
    Console.WriteLine("O site termina com .com");
} else
{
    Console.WriteLine("O site NÃO termina com .com");
}
