using ParProg2;

Console.WriteLine("Heilket dyr vil du ta være på?");
var pikachu = new Pikachu("Pikachu","Sulten","Fornøyd","Må tisse");



while (true)
{
    pikachu.DisplayInfo();
    Console.WriteLine($"1.Gi {pikachu.Name} mat");
    Console.WriteLine($"2.Kos med {pikachu.Name}");
    Console.WriteLine($"3.Sjekk om {pikachu.Name} må på do");
    string svar1 = Console.ReadLine();
    
    if (svar1 == "1")
    {
        pikachu.Mat();
    }

    else if (svar1 == "2")
    {
        pikachu.Kose();
    }

    else if (svar1 == "3")
    {
        pikachu.MåPåDo();
    }
    
}