string Status = "";

Console.WriteLine("O pitoco está destruindo o quintal, chame a atenção dele gritando seu nome");

do
{
    Console.WriteLine("Pitoco continua destruindo o quintal!!");
    string gritar = Console.ReadLine().ToUpper();

    if("PITOCO" == gritar)
    {
        Status = "ok";
    }

}
while(Status != "ok");

Console.WriteLine("Seu grito foi suficiente para chamar atenção do cachorro! Bom trabalho!");