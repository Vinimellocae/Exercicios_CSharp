// Classificar idades

Console.WriteLine("Digite sua idade");
int idade = int.Parse(Console.ReadLine());

bool crianca = idade <= 12 && idade >= 0;
bool adolescente = idade <= 19;
bool adulto = idade <= 59;
bool idoso = idade <= 110;

if(crianca)
{
    Console.WriteLine("Você é criança");
} 
else if(adolescente)
{
    Console.WriteLine("Você é adolescente");
} 
else if(adulto)
{
    Console.WriteLine("Você é adulto");
} 
else if(idoso)
{
    Console.WriteLine("Você é idoso");
}
else
{
    Console.WriteLine("Idade inválida!");
}