// RANDOM -- Aleatoriza Números dentro de um intervalo

Random rnd = new Random();
int NumeroAleatorio = rnd.Next(1, 4); /* Gera um int entre dois valores. O segundo nunca é incluido, neste 
caso pode gerar apenas: {1, 2, 3} */

Console.WriteLine(NumeroAleatorio);