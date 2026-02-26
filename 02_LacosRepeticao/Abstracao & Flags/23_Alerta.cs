List<int> Temperaturas = new List<int> {-2, 234, 43, 12, 30};
bool Alerta = false;

for(int i = 0; i <= Temperaturas.Count() - 1; i++)
{
    if(!(Temperaturas[i] > 37 || Temperaturas[i] < 0)) continue;
    Alerta = true;
    break;
}

Console.WriteLine(Alerta ? "Número critico encontrado" : "Sem alertas por enquanto");