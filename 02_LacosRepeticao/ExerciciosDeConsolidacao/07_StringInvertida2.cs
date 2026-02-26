string Sequencia = "Bom dia Amigos!";
string SequenciaInvertida = "";
int i = Sequencia.Length - 1;

while (true)
{
    SequenciaInvertida += Sequencia[i];
    i--;

    if (i >= 0) continue;
    break;
}

Console.WriteLine(SequenciaInvertida);