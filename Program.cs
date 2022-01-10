using System;

namespace Probleme_Set_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Load();
        }

        private static void Question()
        {
            Console.WriteLine();
            Console.Write("Doriti sa incercati o alta problema (DA/NU): ");
            string answer = Console.ReadLine();
            if (answer.Equals("Da", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.Clear(); Load();
            }
            else
            {
                if (answer.Equals("Nu", StringComparison.CurrentCultureIgnoreCase))
                    return;
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Input invalid. Incercati din nou.");
                    Question();
                }
            }
        }

        private static void Load()
        {
            Console.WriteLine("Probleme - setul 2");
            Console.WriteLine();
            Console.Write("Introduce-ti numarul problemei dorite (1-17) sau cifra '0' pentru a inchide consola: ");
            string nrprob = Console.ReadLine();
            Console.WriteLine();
            switch (nrprob)
            {
                case "0": return;
                case "1": Prob1(); break;
                case "2": Prob2(); break;
                case "3": Prob3(); break;
                case "4": Prob4(); break;
                case "5": Prob5(); break;
                case "6": Prob6(); break;
                case "7": Prob7(); break;
                case "8": Prob8(); break;
                case "9": Prob9(); break;
                case "10": Prob10(); break;
                case "11": Prob11(); break;
                case "12": Prob12(); break;
                case "13": Prob13(); break;/*
                case "14": Prob14(); break;
                case "15": Prob15(); break;
                case "16": Prob16(); break;
                case "17": Prob17(); break;*/
                default: Console.WriteLine("Input invalid. Incercati din nou."); Console.WriteLine(); Load(); break;
            }
        }

        private static void Prob1()
        {
            Console.WriteLine("Problema 1: Se da o secventa de n numere. Sa se determine cate din ele sunt pare.");
            Console.WriteLine();
            Console.Write("Introduce-ti variabila 'n': ");
            int n = int.Parse(Console.ReadLine());
            int var;
            int contor = 0;
            Console.Write($"Introduce-ti {n} numere: ");
            string secventa = Console.ReadLine();
            for (int i=0; i<n; i++)
            {
                var = int.Parse(secventa.Split(' ')[i]);
                if (var % 2 == 0) contor++;
            }
            if (contor == 0) Console.WriteLine("In secventa data nu exista numere pare.");
            else
            {
                if (contor == 1) Console.WriteLine("In secventa data exista un singur numar par.");
                else
                {
                    if (contor == n)
                        Console.WriteLine("Toate numerele din secventa sunt pare.");
                    else Console.WriteLine($"In secventa data exista {contor} numere pare.");
                }
            }
            Question();
        }

        private static void Prob2()
        {
            Console.WriteLine("Problema 2: Se da o secventa de n numere. Sa se determine cate sunt negative, cate sunt zero si cate sunt pozitive.");
            Console.WriteLine();
            Console.Write("Introduce-ti variabila 'n': ");
            int n = int.Parse(Console.ReadLine());
            int var;
            int cnegative = 0;
            int cnull = 0;
            int cpozitive = 0;
            Console.Write($"Introduce-ti {n} numere: ");
            string secventa = Console.ReadLine();
            for (int i = 0; i < n; i++)
            {
                var = int.Parse(secventa.Split(' ')[i]);
                if (var < 0) cnegative++;
                if (var == 0) cnull++;
                if (var > 0) cpozitive++;
            }
            Console.WriteLine();
            Console.Write("In secventa data ");
            if (cnegative == 0) Console.Write("nu exista numere negative, ");
            else
            {
                if (cnegative == 1) Console.Write($"exista un numar negativ, ");
                else Console.Write($"exista {cnegative} numere negative, ");
            }

            if (cnull == 0) Console.Write("nu exista numere egale cu zero si ");
            else
            {
                if (cnull == 1) Console.Write($"exista un numar egal cu zero si ");
                else Console.Write($"exista {cnull} numere egale cu zero si ");
            }

            if (cpozitive == 0) Console.WriteLine("nu exista numere pozitive.");
            else 
            {
                if (cpozitive == 1) Console.WriteLine("exista un numar pozitiv.");
                else Console.WriteLine($"exista {cpozitive} numere pozitive.");
            }
            Question();
        }

        private static void Prob3()
        {
            Console.WriteLine("Problema 3: Calculati suma si produsul numerelor de la 1 la n.");
            Console.WriteLine();
            Console.Write("Introduce-ti variabila 'n': ");
            int n = int.Parse(Console.ReadLine());
            int suma = 0;
            long produs = 1;
            for(int i=1; i<=n; i++)
            {
                suma += i;
                produs *= i;
            }
            Console.WriteLine();
            Console.WriteLine($"Suma numerelor de la 1 la {n} este {suma}, iar produsul lor este {produs}.");
            Question();
        }

        private static void Prob4()
        {
            Console.WriteLine("Problema 4: Se da o secventa de n numere. Determinati pe ce pozitie se afla in secventa un numara a. Se considera ca primul element din secventa este pe pozitia zero. Daca numarul nu se afla in secventa raspunsul va fi -1.");
            Console.WriteLine();
            Console.Write("Introduce-ti variabila 'a': ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Introduce-ti variabila 'n': ");
            int n = int.Parse(Console.ReadLine());
            int var, i;
            bool ok = false;
            Console.Write($"Introduce-ti {n} numere: ");
            string secventa = Console.ReadLine();
            for (i = 0; i < n; i++)
            {
                var = int.Parse(secventa.Split(' ')[i]);
                if (var == a)
                { ok = true; break; }
            }
            if (!ok) i = -1;
            Console.WriteLine($"Numarul 'a' se afla pe pozitia {i}");
            Question();
        }

        private static void Prob5() 
        {
            Console.WriteLine("Problema 5: Cate elemente dintr-o secventa de n numere sunt egale cu pozitia pe care apar in secventa. Se considera ca primul element din secventa este pe pozitia 0.");
            Console.WriteLine();
            Console.Write("Introduce-ti variabila 'n': ");
            int n = int.Parse(Console.ReadLine());
            int var, contor = 0;
            Console.Write($"Introduce-ti {n} numere: ");
            string secventa = Console.ReadLine();
            for (int i = 0; i < n; i++)
            {
                var = int.Parse(secventa.Split(' ')[i]);
                if (var == i) contor++;
            }
            Console.WriteLine();
            if(contor==0) Console.WriteLine($"In secventa data, nu exista astfel de numere.");
            else
            {
                if(contor==1) Console.WriteLine($"In secventa data, exista un singur astfel de numar.");
                else Console.WriteLine($"In secventa data, exista {contor} astfel de numere.");
            }
            Question();
        }

        private static void Prob6()
        {
            Console.WriteLine("Problema 6: Se da o secventa de n numere. Sa se determine daca numerele din secventa sunt in ordine crescatoare.");
            Console.WriteLine();
            Console.Write("Introduce-ti variabila 'n': ");
            int n = int.Parse(Console.ReadLine());
            int var;
            bool ok = true;
            Console.Write($"Introduce-ti {n} numere: ");
            string secventa = Console.ReadLine();
            int lastn = int.Parse(secventa.Split(' ')[0]);
            for (int i = 1; i < n; i++)
            {
                var = int.Parse(secventa.Split(' ')[i]);
                if(var < lastn)
                {
                    ok = false; break;
                }
                lastn = var;
            }
            Console.WriteLine();
            if (ok) Console.WriteLine("Da, numerele din secventa sunt ordonate crescator.");
            else Console.WriteLine("Nu, numerele din secventa nu sunt ordonate crescator.");
            Question();
        }

        private static void Prob7()
        {
            Console.WriteLine("Problema 7: Se da o secventa de n numere. Sa se determine cea mai mare si cea mai mica valoare din secventa.");
            Console.WriteLine();
            Console.Write("Introduce-ti variabila 'n': ");
            int n = int.Parse(Console.ReadLine());
            int var;
            Console.Write($"Introduce-ti {n} numere: ");
            string secventa = Console.ReadLine();
            int minimum = int.Parse(secventa.Split(' ')[0]);
            int maximum = minimum;
            for (int i = 1; i < n; i++)
            {
                var = int.Parse(secventa.Split(' ')[i]);
                if (var < minimum) minimum = var;
                if (var > maximum) maximum = var;
            }
            Console.WriteLine();
            Console.WriteLine($"In secventa data, cea mai mare valoare este {maximum}, iar cea mai mica este {minimum}.");
            Question();
        }

        private static void Prob8()
        {
            Console.WriteLine("Problema 8: Determianti al n-lea numar din sirul lui Fibonacci.");
            Console.WriteLine();
            Console.Write("Introduce-ti variabila 'n': ");
            int n = int.Parse(Console.ReadLine());
            if (n == 1) Console.WriteLine("Primul numar al sirului Fibonacci este 0.");
            if (n == 2) Console.WriteLine("Al 2-lea numar al sirului Fibonacci este 1.");
            int var1 = 0, var2 = 1, var3=0;
            if (n > 2)
            {
                for (int i = 3; i <= n; i++)
                {
                    var3 = var1 + var2;
                    var1 = var2;
                    var2 = var3;
                }
                Console.WriteLine();
                Console.WriteLine($"Al {n}-lea numar al sirului Fibonacci este {var3}.");
            }
            Question();
        }

        private static void Prob9()
        {
            Console.WriteLine("Problema 9: Sa se determine daca o secventa de n numere este monotona.");
            Console.WriteLine();
            Console.Write("Introduce-ti variabila 'n': ");
            int n = int.Parse(Console.ReadLine());
            bool moncres = true, mondesc = true;
            int var;
            bool ok = true;
            Console.Write($"Introduce-ti {n} numere: ");
            string secventa = Console.ReadLine();
            int lastn = int.Parse(secventa.Split(' ')[0]);
            for (int i = 1; i < n; i++)
            {
                var = int.Parse(secventa.Split(' ')[i]);
                if (var < lastn)
                {
                    moncres = false;
                }
                if(var > lastn)
                {
                    mondesc = false;
                }
                if (!moncres && !mondesc)
                    break;
                lastn = var;
            }
            Console.WriteLine();
            if (!moncres && !mondesc)
                Console.WriteLine("Secventa nu este monotona.");
            if (moncres)
                Console.WriteLine("Secventa este monoton crescatoare.");
            if (mondesc)
                Console.WriteLine("Secventa este monoton descrescatoare.");
            Question();
        }

        private static void Prob10()
        {
            Console.WriteLine("Problema 10: Se da o secventa de n numere. Care este numarul maxim de numere consecutive egale din secventa.");
            Console.WriteLine();
            Console.Write("Introduce-ti variabila 'n': ");
            int n = int.Parse(Console.ReadLine());
            int var, contor=1, contormax=0;
            Console.Write($"Introduce-ti {n} numere: ");
            string secventa = Console.ReadLine();
            int lastn = int.Parse(secventa.Split(' ')[0]);
            for (int i = 1; i < n; i++)
            {
                var = int.Parse(secventa.Split(' ')[i]);
                if (var == lastn) contor++;
                else
                {
                    if (contor > contormax) contormax = contor;
                    contor = 1;
                }
                lastn = var;
            }
            Console.WriteLine();
            Console.WriteLine($"Numarul maxim de numere consecutive egale este {contormax}.");
            Question();
        }

        private static int Inversat(int n)
        {
            int aux = 0;
            while(n!=0)
            {
                aux = aux * 10 + n % 10;
                n /= 10;
            }
            return aux;
        }

        private static void Prob11()
        {
            Console.WriteLine("Problema 11: Se da o secventa de n numere, sa se caculeze suma inverselor acestor numere.");
            Console.WriteLine();
            Console.Write("Introduce-ti variabila 'n': ");
            int n = int.Parse(Console.ReadLine());
            int var, suma = 0;
            Console.Write($"Introduce-ti {n} numere: ");
            string secventa = Console.ReadLine();
            for (int i = 0; i < n; i++)
            {
                var = int.Parse(secventa.Split(' ')[i]);
                suma += Inversat(var);
            }
            Console.WriteLine();
            Console.WriteLine($"Suma inverselor numerelor din secventa este {suma}.");
            Question();
        }

        private static void Prob12()
        {
            Console.WriteLine("Problema 12: Cate grupuri de numere consecutive diferite de zero sunt intr-o secventa de n numere.");
            Console.WriteLine();
            Console.Write("Introduce-ti variabila 'n': ");
            int n = int.Parse(Console.ReadLine());
            int var, contor = 0;
            Console.Write($"Introduce-ti {n} numere: ");
            string secventa = Console.ReadLine();
            int lastn = int.Parse(secventa.Split(' ')[0]);
            for (int i = 1; i < n; i++)
            {
                var = int.Parse(secventa.Split(' ')[i]);
                if (var == 0 && lastn !=0) contor++;
                if (i == n - 1 && var != 0) contor++;
                lastn = var;
            }
            Console.WriteLine();
            Console.WriteLine($"In secventa data, exista {contor} grupuri de numere.");
            Question();
        }

        private static void Prob13()
        {
            Console.WriteLine("Problema 13: Determinati daca o secventa de n numere este o secventa crescatoare rotita. ");
            Console.WriteLine();
            Console.Write("Introduce-ti variabila 'n': ");
            int n = int.Parse(Console.ReadLine());
            int var, contor = 0;
            Console.Write($"Introduce-ti {n} numere: ");
            string secventa = Console.ReadLine();
            int lastn = int.Parse(secventa.Split(' ')[0]);
            for (int i = 1; i < n; i++)
            {
                var = int.Parse(secventa.Split(' ')[i]);
                if (var < lastn) contor++;
            }
            Question();
        }

    }
}
