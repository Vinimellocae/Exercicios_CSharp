// Verificar a quantidade de dias de um Mês

Console.WriteLine("digite o numero do mês");
int mes = int.Parse(Console.ReadLine());

bool validarMes = mes <= 12 && mes > 0;

if(validarMes)
{   
    if(mes == 9 || mes == 4 || mes == 6 || mes == 11)
    {
        Console.WriteLine("Seu Mês possui 30 dias");
    } else if(mes == 2)
    {
        Console.WriteLine("Seu Mês possui 28 dias");
    } else
    {
        Console.WriteLine("Seu Mês possui 31 dias");
    }

} else
{
    return;
}