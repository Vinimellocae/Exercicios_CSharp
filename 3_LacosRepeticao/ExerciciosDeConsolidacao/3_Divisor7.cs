int Contador = 0;

for(int i = 1; i < 50; i++)
{
    if(i % 7 == 0) Contador += 1;
}

Console.WriteLine($"Dentro do Intervalo, {Contador} números são divisíveis por 7!");