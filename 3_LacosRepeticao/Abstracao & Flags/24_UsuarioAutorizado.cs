public class Usuario
{
    public bool UsuarioAutorizado {get; set;}
    public int Id_Usuario {get;set;}
}

class Program
{
    static void Main()
    {
        List<Usuario> Usuarios = new List<Usuario>
        {
            new Usuario {Id_Usuario = 1, UsuarioAutorizado = false},
            new Usuario {Id_Usuario = 2, UsuarioAutorizado = false},
            new Usuario {Id_Usuario = 3, UsuarioAutorizado = false},
            new Usuario {Id_Usuario = 4, UsuarioAutorizado = false},
            new Usuario {Id_Usuario = 5, UsuarioAutorizado = false}
        };

        foreach(var usuario in Usuarios)
        {
            usuario.UsuarioAutorizado = true;
            Console.WriteLine($"Usuario {usuario.Id_Usuario}, Autorizado = {usuario.UsuarioAutorizado}");
        }
    }
}
