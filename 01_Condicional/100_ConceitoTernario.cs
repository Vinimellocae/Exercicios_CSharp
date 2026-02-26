//  Receba nota e mostre conceito com operador ternário.

Console.WriteLine("Digite sua nota");
double nota = double.Parse(Console.ReadLine());

bool Erro = nota > 10 || nota < 0;

if(Erro)
{
    Console.WriteLine("Nota inválida! Escolha entre 0 e 10");
    return;
}

bool A = nota == 10; // 10
bool B = nota >= 8 && nota < 10; // 8 a 9,999
bool C = nota >= 7 && nota < 9; // 7 a 8,9999
bool D = nota >= 6 && nota < 8; // 6 a 7,9999

Console.WriteLine(A ? "Você tirou A" : B ? "Você tirou B" : C ? "Você tirou C" : D ? "Você tirou D" : "Você tirou F");