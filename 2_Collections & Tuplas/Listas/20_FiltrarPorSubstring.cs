List<string> Lista = new List<string> { "Bom dia", "Boa Tarde", "Boa noite", "Boa Sorte", "Bom trabalho" };
List<string> ListFiltrada = Lista.FindAll(N => N.Contains("Boa"));

Console.WriteLine(string.Join(", ", ListFiltrada));