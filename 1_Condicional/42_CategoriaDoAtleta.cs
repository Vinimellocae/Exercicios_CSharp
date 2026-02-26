// Categorizar atletas por idade

Console.WriteLine("Digite a idade do atleta");
int idade = int.Parse(Console.ReadLine());

bool Pre_Mirim = idade <= 5;
bool Mirim = idade <=8;
bool Infantil = idade <= 11;
bool Infanto_juvenil = idade <= 14;
bool Juvenil = idade <= 17;
bool Adulto = idade <= 29;
bool Master = idade <= 109;

bool idadeInvalida = idade > 109 || idade < 0;

if(idadeInvalida)
{
    Console.WriteLine("idade inválida");
    return;
}

if(Pre_Mirim){
    Console.WriteLine("A categoria do atleta é Pré Mirim");
} else if(Mirim)
{
    Console.WriteLine("A categoria do atleta é Mirim");
} else if(Infantil)
{
    Console.WriteLine("A categoria do atleta é Infantil");
} else if(Infanto_juvenil)
{
    Console.WriteLine("A categoria do atleta é Infanto Juvenil");
} else if(Juvenil)
{
    Console.WriteLine("A categoria do atleta é Juvenil");
} else if(Adulto)
{
    Console.WriteLine("A categoria do atleta é Adulto");
} else if (Master)
{
    Console.WriteLine("A categoria do atleta é Master");
}