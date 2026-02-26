var Arquivos = new Dictionary<string, string>
{
  {"Index", "php"},  
  {"Logo", "png"},  
  {"Backup", "sql"},  
};

Dictionary<string, string> ArquivosModificados = new();

foreach(var item in Arquivos)
{
    ArquivosModificados.Add(item.Key, "JSON");
}

Console.WriteLine("Arquivos:");

foreach(var item in ArquivosModificados)
{
    Console.WriteLine($"{item.Key}.{item.Value}");
}

