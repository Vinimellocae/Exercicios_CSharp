/* SELECT -- cria nova coleção, não altera a original, pode ser usado para 
criar versões modificadas de listas preexistentes */ 

int[] Lista = { 5, 8, 21, 31, 2 };
int[] Resultado = Lista.Select(n => n * 2).ToArray(); // Multiplica todos os itens da lista por 2
Console.WriteLine(string.Join(", ", Resultado));
