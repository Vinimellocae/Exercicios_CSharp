// Criar pipeline que só executa ao chamar ToList()

var query =
    Enumerable.Range(1, 10)
              .Where(x =>
              {
                  Console.WriteLine($"Filtrando {x}");
                  return x % 2 == 0;
              })
              .Select(x => x * 10);


var resultado = query.ToList();