const int NUMERO_PROIBIDO = 5;

for(int i = 1; i <= 100; i++)
{
    if(i % NUMERO_PROIBIDO == 0) continue;
    Console.WriteLine(i);
}