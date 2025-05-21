namespace ParProg2
{
    public class Pikachu
    {
        public string Name { get; set; }
        public string Sult { get; set; }
        public string Kos { get; set; }

        public string Do { get; set; }
        public Pikachu(string name, string sult, string kos, string wc)
        {
            Name = name;
            Sult = sult;
            Kos = kos;
            Do = wc;
        }

        public void DisplayInfo()
        {
            
        }

        public void Mat()
        {
            Sult = "Mett";
            Console.WriteLine($"{Name} er {Sult}");
        }

        public void Kose()
        {
            Kos = "Glad";
            Console.WriteLine($"{Name} er {Kos}");
        }

        public void MåPåDo()
        {
            Do = "Har vært på do";
            Console.WriteLine($"{Name} er {Do}");
        }


    }
    
}