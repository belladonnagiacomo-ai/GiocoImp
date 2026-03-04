namespace GiocoImp
{
    internal class Program
    {
        static void impiccato(string[] livello1,int livello)
        {
            int z = 0;
            string parola = "", nascosta = "";
            char[] pa, paroleUsate = new char [7];
            Random rnd = new Random();
        
          
            
                int rand = rnd.Next(1, 5);
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
                        Console.WriteLine();
                        Console.WriteLine("Hai " + k + " tentetivi per indovinare la parola segreta");
                        Console.WriteLine();
                        for(int j = 0; j < z; j++)
                        {
                            Console.WriteLine("le parole usate sono: " + paroleUsate[j]);
                        }
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
                        nascosta += "_";

                    }
                    Console.WriteLine(nascosta);
                    pa = nascosta.ToCharArray();
                    for (int k = 7; k > 0; k--)
                    {
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

                }
                else if (rand == 3)
                {

                    parola = livello1[2];
                    for (int i = 0; i < parola.Length; i++)
                    {
                        nascosta += "_";

                    }
                    Console.WriteLine(nascosta);
                    pa = nascosta.ToCharArray();
                    for (int k = 7; k > 0; k--)
                    {
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

                }
            else if (rand == 4)
            {
                parola = livello1[3];
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
                    for (int j = 0; j < z; j++)
                    {
                        Console.WriteLine("le parole usate sono: " + paroleUsate[j]);
                    }
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
            }
            else if (rand == 5)
            {
                parola = livello1[4];
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
                    for (int j = 0; j < z; j++)
                    {
                        Console.WriteLine("le parole usate sono: " + paroleUsate[j]);
                    }
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
            }
        }
           
            
        
        static void Main(string[] args)
        {
            string[] livello1 = { "cane", "albero", "telefono", "volpe", "leone" };
            string[] livello2 = { "orizzonte", "zainetto", "girasole", "astronauta", "avventura"};
            string[] livello3 = { "squarcio", "ziggurat", "alchimia", "soqquadro", "quercia"};
            Console.WriteLine("scegli il livello di difficoltà");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("1/2/3");
            int livello = Convert.ToInt32(Console.ReadLine());
            if(livello == 1)
            {
                impiccato(livello1,livello);
            }
            else if(livello == 2)
            {
                impiccato(livello2, livello);
            }
            else if (livello == 3)
            {
                impiccato(livello3, livello);
            }
           
        }
    }
}
