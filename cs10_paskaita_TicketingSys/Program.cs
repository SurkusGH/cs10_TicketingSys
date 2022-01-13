using System;
using System.Collections.Generic;

namespace cs10_paskaita_TicketingSys
{
    class Program
    {
        public static List<int> bilietai10 = new List<int>(); // <-- saugo sukurtus
        public static List<int> bilietai20 = new List<int>();
        public static List<int> bilietai30 = new List<int>();

        public static List<int> parduota10 = new List<int>(); // <-- naudoju skaičiui parduotų ir likučiui fiksuoti {bilietai10.count} - {parduota10.count}
        public static List<int> parduota20 = new List<int>();
        public static List<int> parduota30 = new List<int>();

        public static List<string> operacijos = new List<string>();  // <-- naudoju bilietų kūrimo skaičiaus inputą,
                                                                     // kurį konvertuoju į stringo formatą ir klijuoju į string listą


        static void Main(string[] args)
        // Meniu: [1] Pirkti bilietus, [2] Kurti bilietus »
        // Pasirinkite bil. Tipą: [1] Po 10€, [2] Po 20€, [3] Po 30€ »
        // Įveskite kiekį: »
        // Kintamieji: int bilietai10, int biletai20... »
        // Metodas KurtiBilietus10(ref bilietai10)...»
        // Metodas ParduotiBilietus10(ref bilietai10)...
        {
            Meniu();
        }
        public static void Meniu()
        {
            while (true)                                    // <-- MAIN MENU - nesibaigiantis loop'as
            {
                Console.WriteLine("[1] Kurti bilietus");
                Console.WriteLine("[2] Parduoti bilietus");
                Console.WriteLine("[3] Statistika");
                Console.WriteLine("[4] Operacijos");

                int input = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (input)
                {
                    case 1:
                        Kūrimas();
                        break;
                    case 2:
                        Pardavimas();
                        break;
                    case 3:
                        Statistika();
                        break;
                    case 4:
                        Operacijos();
                        break;
                }
            }
        }

        public static void Kūrimas()
        {
            Console.WriteLine("[1] Kurti bilietus -> [1] Po €10"); // <-- visur kur matomas simbolis "->" iš esmės yra
            Console.WriteLine("                      [2] Po €20"); //     sintaksinis cukrus. Galima way paprasčiau padaryti
            Console.WriteLine("                      [3] Po €30");
            int input = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (input)
            {
                case 1:
                    KurtiB10();
                    break;
                case 2:
                    KurtiB20();
                    break;
                case 3:
                    KurtiB30();
                    break;
            }
        }

        public static List<int> KurtiB10()
        {
            Console.WriteLine("[1] Kurti bilietus -> [1] Po €10 -> [Skaičius] ");
            Console.WriteLine("                      [2] Po €20");
            Console.WriteLine("                      [3] Po €30");
            int input = int.Parse(Console.ReadLine());
            Console.Clear();

            for (int i = 0; i < input; i++)
            {
                bilietai10.Add(i);
            }
            Console.WriteLine($"[1] Kurti bilietus -> [1] Po €10 -> [Skaičius] -> sukurta {input} vnt., esamas likutis: {bilietai10.Count}");
            Console.WriteLine("                      [2] Po €20");
            Console.WriteLine("                      [3] Po €30");

            operacijos.Add($" sukurta €10 x {input.ToString()} vnt.");

            return bilietai10;
        }

        public static List<int> KurtiB20()
        {
            Console.WriteLine("[1] Kurti bilietus -> [1] Po €10");
            Console.WriteLine("                      [2] Po €20 -> [Skaičius] ");
            Console.WriteLine("                      [3] Po €30");
            int input = int.Parse(Console.ReadLine());
            Console.Clear();
            for (int i = 0; i < input; i++)
            {
                bilietai20.Add(i);
            }
            Console.WriteLine("[1] Kurti bilietus -> [1] Po €10");
            Console.WriteLine($"                      [2] Po €20 -> [Skaičius] -> sukurta {input} vnt., esamas likutis: {bilietai20.Count}");
            Console.WriteLine("                      [3] Po €30");

            operacijos.Add($" sukurta €20 x {input.ToString()} vnt.");

            return bilietai20;
        }

        public static List<int> KurtiB30()
        {
            Console.WriteLine("[1] Kurti bilietus -> [1] Po €10");
            Console.WriteLine("                      [2] Po €20");
            Console.WriteLine("                      [3] Po €30 -> [Skaičius] ");
            int input = int.Parse(Console.ReadLine());
            Console.Clear();
            for (int i = 0; i < input; i++)
            {
                bilietai30.Add(i);
            }
            Console.WriteLine("[1] Kurti bilietus -> [1] Po €10");
            Console.WriteLine("                      [2] Po €20");
            Console.WriteLine($"                      [3] Po €30 -> [Skaičius] -> sukurta {input} vnt., esamas likutis: {bilietai30.Count}");

            operacijos.Add($" sukurta €30 x {input.ToString()} vnt.");

            return bilietai30;

        }

        public static void Pardavimas()
        {

            Console.WriteLine("[2] Parduoti bilietus -> [1] Po €10");
            Console.WriteLine("                         [2] Po €20");
            Console.WriteLine("                         [3] Po €30");
            int input = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (input)
            {
                case 1:
                    Parduoti10();
                    break;
                case 2:
                    Parduoti20();
                    break;
                case 3:
                    Parduoti30();
                    break;
            }

        }

        public static List<int> Parduoti10()
        {
            Console.WriteLine("[2] Parduoti bilietus -> [1] Po €10 -> [Skaičius] ");
            Console.WriteLine("                         [2] Po €20");
            Console.WriteLine("                         [3] Po €30");
            int input = int.Parse(Console.ReadLine());
            Console.Clear();

            for (int i = 0; i < input; i++)
            {
                parduota10.Add(i);
            }
            Console.WriteLine($"[1] Kurti bilietus -> [1] Po €10 -> [Skaičius] -> parduota {input} vnt., esamas {likutisDeficitas()}: {bilietai10.Count - parduota10.Count} vnt.");
            Console.WriteLine("                      [2] Po €20");
            Console.WriteLine("                      [3] Po €30");

            operacijos.Add($"parduota €10 x {input.ToString()} vnt.");

            return parduota10;
        }

        public static List<int> Parduoti20()
        {
            Console.WriteLine("[2] Parduoti bilietus -> [1] Po €10");
            Console.WriteLine("                         [2] Po €20 -> [Skaičius] ");
            Console.WriteLine("                         [3] Po €30");
            int input = int.Parse(Console.ReadLine());
            Console.Clear();

            for (int i = 0; i < input; i++)
            {
                parduota20.Add(i);
            }
            Console.WriteLine("[1] Kurti bilietus -> [1] Po €10");
            Console.WriteLine($"                      [2] Po €20 -> [Skaičius] -> parduota {input} vnt., esamas likutis: {bilietai20.Count - parduota20.Count} vnt.");
            Console.WriteLine("                      [3] Po €30");

            operacijos.Add($"parduota €20 x {input.ToString()} vnt.");

            return parduota20;
        }

        public static List<int> Parduoti30()
        {
            Console.WriteLine("[2] Parduoti bilietus -> [1] Po €10");
            Console.WriteLine("                         [2] Po €20");
            Console.WriteLine("                         [3] Po €30 -> [Skaičius] ");
            int input = int.Parse(Console.ReadLine());
            Console.Clear();

            for (int i = 0; i < input; i++)
            {
                parduota30.Add(i);
            }
            Console.WriteLine("[1] Kurti bilietus -> [1] Po €10");
            Console.WriteLine("                      [2] Po €20");
            Console.WriteLine($"                      [3] Po €30 -> [Skaičius] -> parduota {input} vnt., esamas likutis: {bilietai30.Count - parduota30.Count} vnt.");

            operacijos.Add($"parduota €30 x {input.ToString()} vnt.");

            return parduota30;
        }

        public static void Statistika()
        {
            Console.WriteLine($"Bilietų po €10 sukurta: {bilietai10.Count} vnt.;");
            Console.WriteLine($"              parduota: {parduota10.Count} vnt.;");
            Console.WriteLine($"               likutis: {bilietai10.Count - parduota10.Count} vnt.;");
            Console.WriteLine("");
            Console.WriteLine($"Bilietų po €20 sukurta: {bilietai20.Count} vnt.;");
            Console.WriteLine($"              parduota: {parduota20.Count} vnt.;");
            Console.WriteLine($"               likutis: {bilietai20.Count - parduota20.Count} vnt.;");
            Console.WriteLine("");
            Console.WriteLine($"Bilietų po €30 sukurta: {bilietai30.Count} vnt.;");
            Console.WriteLine($"              parduota: {parduota30.Count} vnt.;");
            Console.WriteLine($"               likutis: {bilietai30.Count - parduota30.Count} vnt.;");
        }

        public static void Operacijos()
        {
            Console.WriteLine("Paskutinės konsolės operacijos: ");
            foreach (var eil in operacijos)
            {
                Console.WriteLine(eil);
            }
            Console.WriteLine();
        }

        public static string likutisDeficitas()
        {
            if (bilietai10.Count < 0)
            {
                string X = "deficitas";
                return X;
            }
            else
            {
                string X = "likutis";
                return X;
            }
        }
    }
}

