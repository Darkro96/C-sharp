using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tasks
{
    class Program
    {
        struct kérdés
        {
            public string fa, kat;
            public int pont, válasz;
        }
        static void Main(string[] args)
        {
            string[] sorok = File.ReadAllLines("felszam.txt");
            int db = sorok.Length / 2;
            kérdés[] t = new kérdés[db];
            for (int i = 0; i < db; i++)
            {
                t[i].fa = sorok[i * 2];
                string[] s = sorok[i * 2 + 1].Split(' ');
                t[i].válasz = int.Parse(s[0]);
                t[i].pont = int.Parse(s[1]);
                t[i].kat = s[2];
            }
            Console.WriteLine("Number of tasks:" + db);
            int dbm = 0, db1 = 0, db2 = 0, db3 = 0;
            for (int i = 0; i < db; i++)
            {
                if (t[i].kat == "mathematics")
                {
                    dbm++;
                    switch (t[i].pont)
                    {
                        case 1:
                            db1++;
                            break;
                        case 2:
                            db2++;
                            break;
                        case 3:
                            db3++;
                            break;
                    }
                }
            }
            Console.WriteLine("number of mathematics tasks: {0}\n1 points mathematics tasks: {1}\n2 points mathematics tasks: {2}\n3 points mathematics tasks: {3}", dbm, db1, db2, db3);
            int min = 0, max = 0;
            for (int i = 0; i < db; i++)
            {
                if (t[i].válasz < t[min].válasz)
                    min = i;
                if (t[i].válasz > t[max].válasz)
                    max = i;
            }
            Console.WriteLine("The maximum response value: {0}\nThe minimum response value: {1}", t[max].válasz, t[min].válasz);
            string[] tk = new string[db];
            int tdb = 0;
            foreach (kérdés k in t)
            {
                int i = 0;
                while (tk[i] != k.kat && i < tdb)
                    i++;
                if (i == tdb)
                {
                    tk[tdb] = k.kat;
                    tdb++;
                }
            }
            Console.WriteLine("Categorys: ");
            for (int i = 0; i < tdb; i++)
            {
                Console.Write(tk[i] + "\n");
            }
            string asd;
            Console.WriteLine("Chose a category!");
            asd = Console.ReadLine();
            Random rand = new Random();
            int r;
            r = rand.Next(db);
            while (t[r].kat != asd)
                r = rand.Next(db);
            Console.WriteLine(t[r].fa);
            int valasz;
            valasz = int.Parse(Console.ReadLine());
            if (t[r].válasz == valasz)
                Console.WriteLine("Good answer\nPont: {0}", t[r].pont);
            else
                Console.WriteLine("The good answer is: {0}", t[r].válasz);
            Console.ReadKey();
        }
    }
}
