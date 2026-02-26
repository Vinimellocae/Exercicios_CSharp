List<string> Lista = new List<string>
{
    "item1",
    "item2",
    "item3"
};

for (int i = 0; i <= Lista.Count(); i++)
{
    Lista[i] = "Processado";
    Console.WriteLine(Lista[i]);
}

// Não é possivel alterar itens de array utilizando foreach!

// Lista.ForEach((item) =>
// {
//     int index = Lista.IndexOf(item);
//     Lista[index] = "processado";
// });

// Console.WriteLine(Lista);