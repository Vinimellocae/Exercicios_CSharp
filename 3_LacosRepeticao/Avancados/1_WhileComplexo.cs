int idade = 22, senha = 12345678;
string nome = "Chapolin";

bool IdadeValida = idade > 0 && idade < 110;
bool SenhaValida = senha.ToString().Length >= 8;
bool NomeValido = nome.All(Char.IsLetter);

while(IdadeValida && SenhaValida && NomeValido)
{
    Console.WriteLine("Você é uma pessoa real");
    break;
}
