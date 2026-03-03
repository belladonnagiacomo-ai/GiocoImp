namespace GiocoImp
{
    internal class Program
    {
        static void impiccato(string[] livello1, string[] livello2, string[] livello3)
        {
            string parola = "";
            Random rnd = new Random();
            Console.WriteLine("scegli il livello di difficoltà");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("1/2/3");
            Console.WriteLine("-------------------------------");
            int livello = Convert.ToInt32(Console.ReadLine());
            if (livello == 1)
            {
                int rand = rnd.Next(1, 3);
                if (rand == 1)
                {
                    livello1[0] = parola;

                }
            }
        }
        static void Main(string[] args)
        {
            string[] livello1 = { "cane", "albero", "telefono" };
            string[] livello2 = { "orizzonte", "zainetto", "girasole" };
            string[] livello3 = { "squarcio", "ziggurat", "alchimia", "osmosi" };
            impiccato(livello1, livello2, livello3);
        }
    }
}
