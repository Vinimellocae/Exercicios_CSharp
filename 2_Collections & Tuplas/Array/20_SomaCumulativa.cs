int[] lista = { 1, 2, 3, 4, 5};
List<int> SomaCumulativa = new List<int> {};
int soma = 0;

for(int i = 0; i < lista.Length; i++)
{
    soma += lista[i];
    SomaCumulativa.Add(soma);
}

Console.WriteLine(string.Join(", ", SomaCumulativa));