// Simplifique um foreach substituindo condicionais aninhados por flags de controle.

int[] Array = [0,1,2,3,4,5,6,7,8,9,10];

foreach(var numero in Array)
{
    bool NumeroEhhPar = numero % 2 == 0;
    string Tipo = NumeroEhhPar ? "Par" : "Impar";

    Console.WriteLine($"O numero {numero} é {Tipo}!");
}