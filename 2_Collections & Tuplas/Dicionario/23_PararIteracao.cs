var Dicionario = new Dictionary<int, string>
{
  {1, "Um"},  
  {2, "Dois"},  
  {3, "Três"},  
  {4, "Quatro"},  
  {5, "Cinco"},  
  {6, "Seis"},  
  {7, "Sete"},  
  {8, "Oito"},  
};

bool Parou = false;
int ChaveProcurada = 5;

foreach(var item in Dicionario.Keys)
{
    if(item == ChaveProcurada)
    {
        Parou = true;
    }

    if(Parou) break;
}

Console.WriteLine(Parou ? "Chave encontrada!" : "Chave inexistente");