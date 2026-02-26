// REMOVEALL -- Remove TODOS os itens que seguirem uma certa condição

List<int> lista = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
lista.RemoveAll(N => N % 2 == 0);
Console.WriteLine(string.Join(", ", lista));

// REMOVE -- Remove o primeiro item da lista de acordo com o parâmetro

List<int> lista2 = new List<int> { 0, 1, 2, 3, 3 };
lista2.Remove(3); // Remover o primeiro 3 da lista
Console.WriteLine(string.Join(", ", lista2));

// REMOVEAT -- Remove o item do index escolhido

List<int> lista3 = new List<int> { 0, 1, 2, 3 };
lista3.RemoveAt(1); 
Console.WriteLine(string.Join(", ", lista3));

// CLEAR -- Remove todos os itens da lista

List<int> lista4 = new List<int> { 0, 1, 2, 3 };
lista4.Clear();
Console.WriteLine(string.Join(", ", lista4));
