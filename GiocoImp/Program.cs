namespace GiocoImp
{
    internal class Program
    {
        static void impiccato(string[] livello1, string[] livello2, string[] livello3)
        {
            int z = 0;
            string parola = "", nascosta = "";
            char[] pa, paroleUsate = { };
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
                        for (int i = 0; i < parola.Length; i++)
                        {
                            nascosta += "_";

                        }
                        Console.WriteLine(nascosta);
                        pa = nascosta.ToCharArray();
                    for(int k = 7; k > 0; k--) {
                        Console.WriteLine("Hai " + k + " tentetivi per indovinare la parola segreta");
                        Console.WriteLine();
                        Console.WriteLine("Inserisci una lettera o vuoi provare ad indovinare la parola?(1/2)?");
                        int scelta = Convert.ToInt32(Console.ReadLine());
                        if (scelta == 1)
                        {
                            Console.WriteLine("Che lettera vuoi inserire?");
                            char lettera = Convert.ToChar(Console.ReadLine());

                            bool contiene = false;
                            contiene = parola.Contains(lettera);
                            if(contiene == true)
                            {
                                for(int i = 0;i < parola.Length; i++)
                                {
                                    if (parola[i] == lettera)
                                    {
                                        pa[i] = lettera;
                                        Console.WriteLine(pa);
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("La lettera " + lettera + " non e nella parola");
                                paroleUsate[z] = lettera;
                                z++;
                            }

                        }
                        else
                        {
                            Console.WriteLine("Inserisci la parola");
                            string indovina = Console.ReadLine();
                            if (indovina == parola)
                            {
                                Console.WriteLine("Hai indovinato la parola, che era " + parola);
                                return;
                            }
                            else
                            {
                                Console.WriteLine("Non hai indovinato la parola");
                            }
                        }


                    }
                    Console.WriteLine("Hai esaurito i tentativi");
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
                else if (rand == 3)
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
