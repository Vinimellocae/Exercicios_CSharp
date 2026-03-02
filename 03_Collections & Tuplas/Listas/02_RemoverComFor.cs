List<int> Lista = new List<int> {1,2,5,6,8,9,10,12,16,21};
// Remover com For é algo que deve ser feito de trás para frente

for(int i = Lista.Count - 1; i >= 0; i--)
{
    if(Lista[i] >= 10) Lista.Remove(Lista[i]);    
}

Console.WriteLine(string.Join(", ", Lista));