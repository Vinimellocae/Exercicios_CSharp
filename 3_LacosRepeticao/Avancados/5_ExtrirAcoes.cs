public class Usuario
{
    public string Nome { get; set; }
    public string Sobrenome { get; set; }
    public DateTime DataAtualizacao { get; set; }
}
class Program
{
    static void Main()
    {
        void AtualizarUsuario(Usuario U)
        {
            U.Nome = U.Nome.ToUpper();
            U.DataAtualizacao = DateTime.Now;
            U.Sobrenome = U.Sobrenome.ToUpper();
        }

        List<Usuario> usuarios = new List<Usuario>
    {
        new Usuario {Nome = "Sonic", Sobrenome = "o Ouriço", DataAtualizacao = DateTime.Today},
        new Usuario {Nome = "Tails", Sobrenome = "A Raposa", DataAtualizacao = DateTime.Today},
        new Usuario {Nome = "Shadow", Sobrenome = "o Ouriço", DataAtualizacao = DateTime.Today}
    };


        usuarios.ForEach(U =>
        {
            AtualizarUsuario(U);
        });
    }

}
