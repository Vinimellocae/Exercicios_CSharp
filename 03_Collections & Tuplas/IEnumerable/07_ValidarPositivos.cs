IEnumerable<int> Numeros = Enumerable.Range(-1, 10);

bool TodosPositivos = Numeros.All(N => N >= 0);

Console.WriteLine(TodosPositivos ? "Todos são positivos" : "Há números negativos!");