bool AlcancarOLimite = false;
int Contador = 0, novo = 1, velho = 0, soma = 0;

Console.WriteLine("1");

while (!AlcancarOLimite)
{
    soma = velho + novo;
    velho = novo;
    novo = soma;

    Console.WriteLine(soma);

    Contador++;
    if (Contador == 19) AlcancarOLimite = true;
}