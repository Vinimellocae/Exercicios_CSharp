const int TAMANHO_LIMITE = 8;

string[] lista = ["Banana", "Maçã", "Pera", "Fruta do Dragão", "Bergamota", "Abacate"];

foreach(var item in lista)
{
    if(item.Length > TAMANHO_LIMITE)
    {
        Console.WriteLine($"{item} ultrapassa o tamanho limite");
    }
    else
    {
        Console.WriteLine($"{item} está dentro do tamanho limite!");
    }
}