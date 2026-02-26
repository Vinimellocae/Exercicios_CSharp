//  Verifique se uma senha contém número

Console.WriteLine("Escreva sua senha");
string senha = Console.ReadLine();

bool senhaComNumero = senha.Any(char.IsDigit);

Console.WriteLine(senhaComNumero ? "A senha possui numeros" : "A senha NÃO possui numeros");