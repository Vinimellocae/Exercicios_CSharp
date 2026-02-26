public class Cliente
{
    public bool CLIENTE_ATIVO { get; set; }
}

class Program
{
    static void Main()
    {
        List<Cliente> lista = new List<Cliente>
        {
            new Cliente {CLIENTE_ATIVO = false}, 
            new Cliente {CLIENTE_ATIVO = false},
            new Cliente {CLIENTE_ATIVO = false} 
        };

        foreach(var item in lista)
        {
            item.CLIENTE_ATIVO = true;
            Console.WriteLine(item.CLIENTE_ATIVO);
        }
    }
}

