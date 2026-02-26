public class Documento
{
    public bool FLAG_REVISADO {get; set;}
    public int ID_DOCUMENTO {get; set;}
}

class Program
{
    static void Main()
    {
        List<Documento> Documentos = new List<Documento>
        {
            new Documento {ID_DOCUMENTO = 1, FLAG_REVISADO = false,}, 
            new Documento {ID_DOCUMENTO = 2, FLAG_REVISADO = false,}, 
            new Documento {ID_DOCUMENTO = 3, FLAG_REVISADO = false,}, 
            new Documento {ID_DOCUMENTO = 4, FLAG_REVISADO = false,}, 
        };

        Documentos.ForEach(D =>
        {
           D.FLAG_REVISADO = true;
           Console.WriteLine($"Documento {D.ID_DOCUMENTO}, Revisado = {D.FLAG_REVISADO}"); 
        });
    }
}