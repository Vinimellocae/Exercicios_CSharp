// Exists -- Verifica a existência de algo e retorna True ou False

List<int> Lista = new List<int> {1,2,3,4,5,6,7,8,9,10};
bool MaioresDe5 = Lista.Exists(N => N > 5);
Console.WriteLine(MaioresDe5 ? "Existem números maiores que cinco" : "Não exitem maiores de 5");