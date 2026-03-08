namespace GiocoImp
{
    internal class Program
    {
        static char[] paroleU(char[] paroleUsate, int z)
        {
            for (int j = 0; j < z; j++)
            {
                Console.WriteLine("le parole usate sono: " + paroleUsate[j]);
            }
            return paroleUsate;
        }
        static void gioco(string[] animaleFacile, int livello)
        {
            int z = 0;
            string parola = "", nascosta = "";
            char[] pa, paroleUsate = new char[7];
            Console.WriteLine();
            parola = animaleFacile[0];
            for (int i = 0; i < parola.Length; i++)
            {
                nascosta += "_";

            }

            Console.WriteLine(nascosta);
            pa = nascosta.ToCharArray();
            for (int k = 7; k > 0; k--)
            {
                Console.WriteLine();
                Console.WriteLine("Hai " + k + " tentetivi per indovinare la parola segreta");
                Console.WriteLine();
                paroleU(paroleUsate, z);
                Console.WriteLine();
                Console.WriteLine("Inserisci una lettera o vuoi provare ad indovinare la parola?(1/2)?");
                int scelta = Convert.ToInt32(Console.ReadLine());
                if (scelta == 1)
                {
                    Console.WriteLine("Che lettera vuoi inserire?");
                    char lettera = Convert.ToChar(Console.ReadLine());
                    bool contiene = false;
                    contiene = parola.Contains(lettera);
                    if (contiene == true)
                    {
                        for (int i = 0; i < parola.Length; i++)
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
            Console.WriteLine("La parola e: " + parola);
        }

        static void impiccato(string[] animaleFacile, int livello)
        {

            Random rnd = new Random();
            int rand = rnd.Next(1, 5);
            if (rand == 1)
            {
                gioco(animaleFacile, livello);
            }
            else if (rand == 2)
            {
                gioco(animaleFacile, livello);
            }
            else if (rand == 3)
            {
                gioco(animaleFacile, livello);

            }
            else if (rand == 4)
            {
                gioco(animaleFacile, livello);
            }
            else if (rand == 5)
            {
                gioco(animaleFacile, livello);
            }


            static void Main(string[] args)
            {
                string[] animaleFacile = { "cane", "gatto", "leone", "lupo", "orso" };
                string[] animaleMedio = { "ghepardo", "canguro", "delfino", "gorilla", "pantera" };
                string[] animaleDifficile = { "ornitorinco", "axolotl", "albatros", "camaleonte", "ippopotamo" };

                string[] paesiFacile = { "italia", "spagna", "brasile", "francia", "egitto" };
                string[] paesiMedio = { "giappone", "norvegia", "messico", "turchia", "vietnam" };
                string[] paesiDifficile = { "kiribati", "azerbaigian", "suriname", "kazakistan", "madagascar" };

                string[] tecnologiaFacile = { "mouse", "tablet", "router", "schermo", "tastiera" };
                string[] tecnologiaMedio = { "processore", "algoritmo", "firewall", "database", "scanner" };
                string[] tecnologiaDifficile = { "crittografia", "microcontrollore", "backend", "blockchain", "framework" };
                Console.WriteLine();
                Console.WriteLine("che categoria vuoi(animali/paesi/tecnologia)?");
                string categoria = Console.ReadLine();
                if (categoria == "animali")
                {
                    Console.WriteLine("scegli il livello di difficoltà");
                    Console.WriteLine("-------------------------------");
                    Console.WriteLine("1/2/3");
                    int livello = Convert.ToInt32(Console.ReadLine());
                    if(livello == 1)
                    {
                        impiccato(animaleFacile, livello);
                    }
                    else if(livello == 2)
                    {
                        impiccato(animaleMedio, livello);
                    }
                    else if(livello == 3)
                    {
                        impiccato(animaleDifficile, livello);
                    }

                }
                else if(categoria == "paesi")
                {
                    Console.WriteLine("scegli il livello di difficoltà");
                    Console.WriteLine("-------------------------------");
                    Console.WriteLine("1/2/3");
                    int livello = Convert.ToInt32(Console.ReadLine());
                    if (livello == 1)
                    {
                        impiccato(paesiFacile, livello);
                    }
                    else if (livello == 2)
                    {
                        impiccato(paesiMedio, livello);
                    }
                    else if (livello == 3)
                    {
                        impiccato(paesiDifficile, livello);
                    }
                }
                else if(categoria == "tecnologia")
                {
                    Console.WriteLine("scegli il livello di difficoltà");
                    Console.WriteLine("-------------------------------");
                    Console.WriteLine("1/2/3");
                    int livello = Convert.ToInt32(Console.ReadLine());
                    if (livello == 1)
                    {
                        impiccato(tecnologiaFacile, livello);
                    }
                    else if (livello == 2)
                    {
                        impiccato(tecnologiaMedio, livello);
                    }
                    else if (livello == 3)
                    {
                        impiccato(tecnologiaDifficile, livello);
                    }
                }



            }
        }
    }
}
