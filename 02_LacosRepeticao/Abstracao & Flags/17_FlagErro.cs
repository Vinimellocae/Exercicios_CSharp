bool FLAG_ERRO = false;

do
{
    Console.WriteLine("Escreva algo que contenha 5 caracters:");
    string palavra = Console.ReadLine();

    if (palavra.Length != 5)
    {
        FLAG_ERRO = true;
    }
}
while (!FLAG_ERRO);

Console.WriteLine("Erro encontrado!");