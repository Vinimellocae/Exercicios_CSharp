public class Objeto
{
    public bool Ativo {get; set;}
    public string Nome {get; set;}    
}

class Program
{
    static void Main()
    {
        List<Objeto> objetos = new List<Objeto>
        {
            new Objeto {Ativo = true, Nome = "VT"},
            new Objeto {Ativo = false, Nome = "VR"},
            new Objeto {Ativo = false, Nome = "VA"}
        };

        foreach(var objeto in objetos)
        {
            if(objeto.Ativo)
            {
                Console.WriteLine($"O seu {objeto.Nome} já está ativado!");
            }
            else
            {
                Console.WriteLine($"O seu {objeto.Nome} não está ativado, vamos revisar o mais rápido possível!");
            }
        }
    }
}