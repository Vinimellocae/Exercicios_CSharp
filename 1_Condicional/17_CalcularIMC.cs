// Criar uma calculadora de IMC - Indice de massa corporal

Console.WriteLine("Digite sua altura em cm");
float altura = float.Parse(Console.ReadLine());

altura = altura / 100;

Console.WriteLine("Digite seu peso");
float peso = float.Parse(Console.ReadLine());

float IMC =  peso / (altura * altura);

if(IMC < 18.5)
{
    Console.WriteLine("Abaixo do Peso!");
} else if(IMC < 24.9)
{
    Console.WriteLine("Peso normal!");
} else if(IMC < 29.9)
{
    Console.WriteLine("Sobrepeso!");
} else
{
    Console.WriteLine("Obesidade!");
}