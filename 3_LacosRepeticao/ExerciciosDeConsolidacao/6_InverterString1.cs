string String = "String Normal!";
string StringInvertida = "";

for (int i = String.Length - 1; i >= 0; i--)
{
    StringInvertida += String[i];
}

Console.WriteLine(StringInvertida);