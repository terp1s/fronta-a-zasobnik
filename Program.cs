using System;

namespace supr_cupr_znamkovany_ukol
{
    class Spojak
    {
        public Node Zacatek { get; set; }
        public Node Konec { get; set; }

        public Spojak()
        {
            
            
        }
    }
    class Node
    {
        public Node Next { get; set; }

        public int Number { get; set; }

        public Node(int i)
        {
            Number = i;
        }

        public Node()
        {

        }
    }
    class Fronta
    {
        Spojak Spojak { get; }  = new Spojak();
        public void Vloz(int i)
        {
            Node novy = new Node(i);

            if (Spojak.Zacatek == null)
            {
                Spojak.Zacatek = novy;
                Spojak.Konec = Spojak.Zacatek;
            }
            else
            {
                Spojak.Konec.Next = novy;
                Spojak.Konec = Spojak.Konec.Next;
            }

        }

        public int VratPrvek()
        {
            return Spojak.Zacatek.Number;
        }

        public void OdeberPrvek()
        {
            Spojak.Zacatek = Spojak.Zacatek.Next;
        }

        public bool Prazdna()
        {
            if (Spojak.Zacatek == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    class Zasobnik
    {
        Spojak Spojak { get; } = new Spojak();

        public void Vloz(int i)
        {
            Node novy = new Node(i);
            novy.Next = Spojak.Zacatek;
            Spojak.Zacatek = novy;
        }

        public int VratPrvek()
        {
            return Spojak.Zacatek.Number;
        }

        public void OdeberPrvek()
        {
            Spojak.Zacatek = Spojak.Zacatek.Next;
        }

        public bool Prazdna()
        {
            if (Spojak.Zacatek == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Zasobnik test = new Zasobnik();
            Console.WriteLine(test.Prazdna());
            test.Vloz(5);
            test.Vloz(8);
            test.Vloz(13);
            Console.WriteLine(test.Prazdna());
            Console.WriteLine(test.VratPrvek());
            test.OdeberPrvek();
            Console.WriteLine(test.VratPrvek());

            Fronta test2 = new Fronta();
            Console.WriteLine(test2.Prazdna());
            test2.Vloz(5);
            test2.Vloz(8);
            test2.Vloz(13);
            Console.WriteLine(test2.Prazdna());
            Console.WriteLine(test2.VratPrvek());
            test2.OdeberPrvek();
            Console.WriteLine(test2.VratPrvek());

            Console.ReadKey();
        }
    }
}
