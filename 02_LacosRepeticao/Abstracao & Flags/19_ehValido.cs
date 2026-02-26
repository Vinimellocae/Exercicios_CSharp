public class Elemento
{
    public bool Is_Valido { get; set; }
    public int Id { get; set; }
}

class Program
{
    static void Main()
    {
        List<Elemento> Elementos = new List<Elemento>
        {
            new Elemento {Is_Valido = true, Id = 1},
            new Elemento {Is_Valido = true, Id = 2},
            new Elemento {Is_Valido = true, Id = 3},
            new Elemento {Is_Valido = false, Id = 4},
            new Elemento {Is_Valido = true, Id = 5}
        };

        int Contador = 0;

        foreach (var item in Elementos)
        {
            if (item.Is_Valido == true)
            {
                Contador++;
            }
        }

        Console.WriteLine($"{Contador} elementos são válidos!");
    }
}
