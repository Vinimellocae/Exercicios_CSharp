public class Usuarios
{
    public string Nome {get; set;}
    public bool isAdmin {get; set;}
}

class Program
{
    static void Main()
    {
        List<Usuarios> usuarios = new List<Usuarios>
        {
            new Usuarios {Nome = "Chaves", isAdmin = true},
            new Usuarios {Nome = "Quico", isAdmin = false},
            new Usuarios {Nome = "Chiquinha", isAdmin = false},
            new Usuarios {Nome = "Seu Madruga", isAdmin = true}
        };

        usuarios.ForEach(U =>
        {
           U.Nome += "_novo";
           U.isAdmin = true;

           Console.WriteLine($"Usuario: {U.Nome}; É administrador: {U.isAdmin} "); 
        });
    }
}