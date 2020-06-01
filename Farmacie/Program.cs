//Vizitiu Alexandru 3123b
using System;
 


namespace Farmacie
{
    class Program
    {
        static void Main(string[] args)
        {
            Medicamente[] med = new Medicamente[100];
            int nrMed = 0;


            while (true)
            {
                Console.WriteLine("Alegeti o optiune:");
                Console.WriteLine("A)Adaugare medicament.");
                Console.WriteLine("L)Afisare lista medicamente.");
                Console.WriteLine("F)Cautare medicament dupa nume si afisare cantitate.");
                Console.WriteLine("G)Cautare medicamente dupa pret si afisare medicamente cu pretul respectiv.");
                Console.WriteLine("T)Editare element.");
                
                Console.WriteLine("K)Adaugare in fisier txt");
                Console.WriteLine("C)Preluare date din fisier text");
                Console.WriteLine("I)Info autor.");
                Console.WriteLine("X)Iesire");
                string opt = Console.ReadLine();
                Console.Clear();
                switch (opt.ToUpper())
                {
                    case "A":
                        Console.WriteLine("Introduceti denumirea: ");

                        string s1 = Console.ReadLine();
                        if (s1 == string.Empty)
                        {
                            Console.WriteLine("Denumire incorecta,reintroduceti: ");
                            s1 = Console.ReadLine();
                        }

                        Console.WriteLine("Introduceti pretul");
                        double p;

                        p = Convert.ToDouble(Console.ReadLine());
                        if (p < 1)
                        {
                            Console.WriteLine("Pret invalid,reintroduceti:");
                            p = Convert.ToDouble(Console.ReadLine());
                        }
                        int type;
                        Console.WriteLine("Introduceti tipul:");
                        Console.WriteLine("1)Comprimat.");
                        Console.WriteLine("2)Sirop.");
                        Console.WriteLine("3)Unguent.");
                        type = Convert.ToInt32(Console.ReadLine());
                        if (type < 0 || type > 3)
                        {
                            Console.WriteLine("Tip invalid,reintroduceti");
                            type = Convert.ToInt32(Console.ReadLine());
                        }
                        int pres;
                        Console.WriteLine("Necesita prescriptie?");
                        Console.WriteLine("0)Nu");
                        Console.WriteLine("1)Da");
                        pres = Convert.ToInt32(Console.ReadLine());
                        if (pres != 0 && pres != 1)
                        {
                            Console.WriteLine("Optiune invalida,reintroduceti:");
                            pres = Convert.ToInt32(Console.ReadLine());
                        }
                        nrMed++;


                        med[nrMed] = new Medicamente(s1, p, type, pres);
                        for (int l = 1; l <= nrMed; l++)
                        {


                            med[l].cantitate = 1;

                        }

                        break;
                    case "L":
                        for (int i = 1; i <= nrMed; i++)
                        {
                            Console.WriteLine(i + "." + med[i].Afisare());
                        }
                        break;
                    case "F":
                        Console.WriteLine("Introduceti denumirea medicamentului cautat:");
                        string s2 = Console.ReadLine();
                        for (int i = 1; i <= nrMed; i++)
                        {
                            if (s2 == med[i].nume)
                            {
                                if (med[i].nume == med[i + 1].nume && med[i].TIP == med[i + 1].TIP)
                                    med[i].cantitate++;
                                Console.WriteLine("Medicament gasit,stoc" + " " + med[i].cantitate + " " + "bucati");
                                break;


                            }
                            else
                            {

                                Console.WriteLine("Medicamentul introdus nu a fost gasit.");




                            }



                        }
                        break;
                    case "I":
                        Console.WriteLine("Vizitiu Alexandru 3123b");
                        break;
                    case "X":
                        System.Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Optiune invalida,incercati din nou!");
                        break;
                    case "G":
                        Console.WriteLine("Introduceti pretul dorit: ");
                        double y = Convert.ToDouble(Console.ReadLine());
                        if (y < 1)
                        {
                            Console.WriteLine("Pret invalid,reintroduceti");
                            y = Convert.ToDouble(Console.ReadLine());
                        }
                        Console.WriteLine("Urmatoarele medicamente corespund pretului introdus:");
                        for (int i = 1; i <= nrMed; i++)
                        {
                            if (med[i].pret == y)
                            {
                                Console.WriteLine(med[i].nume.ToUpper());
                                continue;

                            }
                            else
                            {
                                Console.WriteLine("Niciun medicament cu pretul introdus nu a fost gasit.");
                                continue;
                            }

                        }
                        break;
                    case "T":
                        Console.WriteLine("Introduceti pozitia elementului de modificat:");
                        int poz = Convert.ToInt32(Console.ReadLine());
                        if (poz < nrMed || poz > nrMed)
                        {
                            Console.WriteLine("Pozitie invalida,introduceti din nou:");
                            poz = Convert.ToInt32(Console.ReadLine());
                        }
                        for (int k = 1; k <= nrMed; k++)
                        {
                            if (poz == k)
                            {
                                Console.WriteLine("Introduceti noua denumire:");
                                string s3 = Console.ReadLine();
                                if (s3 == string.Empty)
                                {
                                    Console.WriteLine("Denumire invalida,reintroduceti:");
                                    s3 = Console.ReadLine();

                                }

                                Console.WriteLine("Introduceti noul pret:");
                                double pr = Convert.ToDouble(Console.ReadLine());
                                if (pr < 1)
                                {
                                    Console.WriteLine("Pret invalid,reintroduceti:");
                                    pr = Convert.ToDouble(Console.ReadLine());
                                }


                                Console.WriteLine("Introduceti noul tip:");

                                Console.WriteLine("1)Comprimat.");
                                Console.WriteLine("2)Sirop.");
                                Console.WriteLine("3)Unguent.");
                                int tp = Convert.ToInt32(Console.ReadLine());
                                if (tp < 0 || tp > 3)
                                {
                                    Console.WriteLine("Tip invalid,reintroduceti");
                                    tp = Convert.ToInt32(Console.ReadLine());
                                }
                                Console.WriteLine("Necesita prescriptie?");
                                Console.WriteLine("0)Nu");
                                Console.WriteLine("1)Da");

                                int pres1 = Convert.ToInt32(Console.ReadLine());
                                if (pres1 != 0 && pres1 != 1)
                                {
                                    Console.WriteLine("Optiune invalida,reintroduceti:");
                                    pres1 = Convert.ToInt32(Console.ReadLine());
                                }

                                med[k] = new Medicamente(s3, pr, tp, pres1);



                            }


                        }
                        break;
                    
                    case "K":
                        Op_Text x = new Op_Text("test.txt");
                        for (int a = 1; a <= nrMed; a++)
                        {
                            x.AddMedicament(med[a]);
                        }
                        break;
                    case "C":
                        Op_Text x1 = new Op_Text("test.txt");

                        med = x1.GetMed(out nrMed);
                        

                        break;

                }

            }


        }
    }
}
