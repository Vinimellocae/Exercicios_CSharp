// Verifique se um ponto (x,y) está no 1º, 2º, 3º ou 4º quadrante.

Console.WriteLine("Digite o valor de X");
int cordX = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor de Y");
int cordY = int.Parse(Console.ReadLine());

bool ambosZeros = cordX == 0 && cordY == 0;
bool zero = cordX == 0 || cordY == 0;

if(ambosZeros)
{
    Console.WriteLine("Sua coordenada se encontra na origem");
    return;
} else if(zero)
{
    Console.WriteLine("Sua coordenada não se encontra em nenhum quadrante");
    return;
}

bool primeiro = cordX > 0 && cordY > 0;
bool segundo = cordX < 0 && cordY > 0;
bool terceiro = cordX < 0 && cordY < 0;
bool quarto = cordX > 0 && cordY < 0;

if(primeiro)
{
    Console.WriteLine("Sua coordenada se encontra no primeiro quadrante");
} else if(segundo)
{
    Console.WriteLine("Sua coordenada se encontra no segundo quadrante");
} else if(terceiro)
{
    Console.WriteLine("Sua coordenada se encontra no terceiro quadrante");
} else if(quarto)
{
    Console.WriteLine("Sua coordenada se encontra no quarto quadrante");
}