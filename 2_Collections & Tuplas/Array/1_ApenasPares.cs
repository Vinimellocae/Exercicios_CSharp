int[] numeros = [1,2,3,4,5,6,7,8,9,10];

foreach(var numero in numeros)
{
    bool Par = numero % 2 == 0;
    if(!Par) continue;
    Console.WriteLine(numero);
}