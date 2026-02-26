public class Alunos
{
    public string Nome { get; set; }
    public double Nota { get; set; }
    public bool Aprovado {get; set;}
}

class Program
{
    static void Main()
    {
        List<Alunos> alunos = new List<Alunos>
        {
            new Alunos {Nome = "João", Nota = 560},
            new Alunos {Nome = "Rodrigo", Nota = 670},
            new Alunos {Nome = "Helena", Nota = 830},
            new Alunos {Nome = "Raimundo", Nota = 212},
            new Alunos {Nome = "Milena", Nota = 740}
        };

        const double NOTA_DE_CORTE = 650;

        alunos.ForEach(A =>
        {
            if (A.Nota >= NOTA_DE_CORTE)
            {
                A.Aprovado = true;
                Console.WriteLine($"{A.Nome} conseguiu a vaga na universidade com {A.Nota} pontos! Aprovado(a)");
            }
            else
            {
                A.Aprovado = false;
                Console.WriteLine($"{A.Nome} NÃO conseguiu a vaga na universidade. Reprovado(a)");
            }
        });
    }
}