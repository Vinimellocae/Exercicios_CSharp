// Diferente do Where, o Find pode ser utilizado somente em listas!

// FIND -- Encontra o primeiro item que atender uma condição
List<int> lista = new List<int> { 1, 2, 3, 4, 5, 6 };
int PrimeiroPar = lista.Find(N => N % 2 == 0); // Busca o primeiro par na lista
Console.WriteLine(PrimeiroPar);

//FINDALL -- Encotra TODOS os itens que atenderem uma certa condição!
List<int> Pares = lista.FindAll(N => N % 2 == 0);
Console.WriteLine(string.Join(", ", Pares));