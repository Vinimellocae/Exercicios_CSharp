List<string> Palavras = new List<string> {"Carneiros", "Gatos", "Bodes", "Papagaios", "Tamanduás"};
const string SUFIXO = "_tranquilos";

Palavras.ForEach(p =>
{
    Console.WriteLine(p + SUFIXO);
});

