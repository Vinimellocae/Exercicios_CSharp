public class Objeto
{
    public string NOME_PROPRIEDADE { get; set; }
}

class Program
{
    static void main()
    {
        List<Objeto> lista = new List<Objeto>
        {
            new Objeto {NOME_PROPRIEDADE = "Batedeira"}, 
            new Objeto {NOME_PROPRIEDADE = "Fogão"},
            new Objeto {NOME_PROPRIEDADE = "Guardanapos"} 
        };

        foreach(var item in lista)
        {
            Console.WriteLine(item.NOME_PROPRIEDADE);
        }
    }
}


