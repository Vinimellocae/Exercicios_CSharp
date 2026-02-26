List<string> Eletrodomesticos = new List<string> {"Micro-ondas", "Geladeira", "Freezer", "Fogão", "Maquina de Lavar"};

foreach(var item in Eletrodomesticos)
{
    bool FLAG_ENCONTRADO = item == "Fogão";
    
    if(FLAG_ENCONTRADO)
    {
        Console.WriteLine($"{item}.. Item encontrado!");
        return;
    } 

    Console.WriteLine($"{item}..");
}