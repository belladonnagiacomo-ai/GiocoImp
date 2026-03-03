namespace GiocoImp
{
    internal class Program
    {
        static void impiccato(string[] livello1, string[] livello2, string[] livello3)
        {
            string parola = "", lettera = "", p = "";
            Random rnd = new Random();
            Console.WriteLine("scegli il livello di difficoltà");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("1/2/3");
            int livello = Convert.ToInt32(Console.ReadLine());
            if (livello == 1)
            {
                int rand = rnd.Next(1, 3);
                if (rand == 1)
                {
                    parola = livello1[0];
                    for(int i = 0;i< parola.Length; i++)
                    {
                        parola = parola.Replace(parola[i], '_');
                       
                    }
                    Console.WriteLine(parola);
                    Console.WriteLine();
                    Console.WriteLine("Inserisci una lettera o vuoi provare ad indovinare la parola?(1/2)?");
                    int scelta = Convert.ToInt32(Console.ReadLine());
                    if(scelta == 1)
                    {
                        Console.WriteLine("Che lettera vuoi inserire?");
                        lettera = Console.ReadLine();
                        bool s = false;
                        s = parola.Contains(lettera);
                        if(s = true)
                        {
                            for(int i = 0; i< p.Length; i++)
                            {
                                int punto = p.IndexOf(lettera);
                                p = parola.Replace(parola[punto], lettera[0]);
                            }
                            Console.WriteLine(p);
                        }
                    }


                }
                else if (rand == 2)
                {
                    parola = livello1[1];
                    for (int i = 0; i < parola.Length; i++)
                    {
                        parola = parola.Replace(parola[i], '_');

                    }
                    Console.WriteLine(parola);

                }
                else if(rand == 3)
                {
                    parola = livello1[2];
                    for (int i = 0; i < parola.Length; i++)
                    {
                        parola = parola.Replace(parola[i], '_');

                    }
                    Console.WriteLine(parola);

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
