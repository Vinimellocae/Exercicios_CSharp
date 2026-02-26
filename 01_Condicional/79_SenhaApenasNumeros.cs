// Receba string e verifique se contém apenas números.

Console.WriteLine("Digite sua senha");
string senha = Console.ReadLine();

bool apenasNumeros = senha.All(char.IsDigit);

Console.WriteLine(apenasNumeros ? "A senha contém apenas numeros" : "A senha não possui somente números");