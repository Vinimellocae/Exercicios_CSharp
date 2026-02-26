class Pedido
{
    public bool PEDIDO_APROVADO { get; set; }
    public int Id { get; set; }
}

class Program
{
    static void Main()
    {
        List<Pedido> pedidos = new List<Pedido> {
            new Pedido { Id = 1, PEDIDO_APROVADO = false },
            new Pedido { Id = 2, PEDIDO_APROVADO = false },
            new Pedido { Id = 3, PEDIDO_APROVADO = false }
        };

        foreach (var item in pedidos)
        {
            item.PEDIDO_APROVADO = true;
        }

        foreach (var item in pedidos)
        {
            Console.WriteLine($"Pedido {item.Id}, Aprovado: {item.PEDIDO_APROVADO}");
        }
    }
}