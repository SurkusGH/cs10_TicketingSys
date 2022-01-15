using System;
using System.Collections.Generic;

namespace cs10_paskaita_TicketingSys
{
    class Program
    {
        public static List<int> tickets10 = new List<int>(); // <-- saugo sukurtus
        public static List<int> tickets20 = new List<int>();
        public static List<int> tickets30 = new List<int>();

        public static List<int> sold10 = new List<int>(); // <-- naudoju skaičiui parduotų ir likučiui fiksuoti {bilietai10.count} - {parduota10.count}
        public static List<int> sold20 = new List<int>();
        public static List<int> sold30 = new List<int>();

        public static List<string> transactions = new List<string>();  // <-- naudoju bilietų kūrimo skaičiaus inputą,
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
                        Create();
                        break;
                    case 2:
                        Sell();
                        break;
                    case 3:
                        Statystics();
                        break;
                    case 4:
                        Operations();
                        break;
                }
            }
        }

        public static void Create()
        {
            Console.WriteLine("[1] Kurti bilietus -> [1] Po €10"); // <-- visur kur matomas simbolis "->" iš esmės yra
            Console.WriteLine("                      [2] Po €20"); //     sintaksinis cukrus. Galima way paprasčiau padaryti
            Console.WriteLine("                      [3] Po €30");
            int input = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (input)
            {
                case 1:
                    CreateTicket10();
                    break;
                case 2:
                    CreateTicket20();
                    break;
                case 3:
                    CreateTicket30();
                    break;
            }
        }

        public static List<int> CreateTicket10()
        {
            Console.WriteLine("[1] Kurti bilietus -> [1] Po €10 -> [Skaičius] ");
            Console.WriteLine("                      [2] Po €20");
            Console.WriteLine("                      [3] Po €30");
            int input = int.Parse(Console.ReadLine());
            Console.Clear();

            for (int i = 0; i < input; i++)
            {
                tickets10.Add(i);
            }
            Console.WriteLine($"[1] Kurti bilietus -> [1] Po €10 -> [Skaičius] -> sukurta {input} vnt., esamas likutis: {tickets10.Count}");
            Console.WriteLine("                      [2] Po €20");
            Console.WriteLine("                      [3] Po €30");

            transactions.Add($" sukurta €10 x {input.ToString()} vnt.");

            return tickets10;
        }

        public static List<int> CreateTicket20()
        {
            Console.WriteLine("[1] Kurti bilietus -> [1] Po €10");
            Console.WriteLine("                      [2] Po €20 -> [Skaičius] ");
            Console.WriteLine("                      [3] Po €30");
            int input = int.Parse(Console.ReadLine());
            Console.Clear();
            for (int i = 0; i < input; i++)
            {
                tickets20.Add(i);
            }
            Console.WriteLine("[1] Kurti bilietus -> [1] Po €10");
            Console.WriteLine($"                      [2] Po €20 -> [Skaičius] -> sukurta {input} vnt., esamas likutis: {tickets20.Count}");
            Console.WriteLine("                      [3] Po €30");

            transactions.Add($" sukurta €20 x {input.ToString()} vnt.");

            return tickets20;
        }

        public static List<int> CreateTicket30()
        {
            Console.WriteLine("[1] Kurti bilietus -> [1] Po €10");
            Console.WriteLine("                      [2] Po €20");
            Console.WriteLine("                      [3] Po €30 -> [Skaičius] ");
            int input = int.Parse(Console.ReadLine());
            Console.Clear();
            for (int i = 0; i < input; i++)
            {
                tickets30.Add(i);
            }
            Console.WriteLine("[1] Kurti bilietus -> [1] Po €10");
            Console.WriteLine("                      [2] Po €20");
            Console.WriteLine($"                      [3] Po €30 -> [Skaičius] -> sukurta {input} vnt., esamas likutis: {tickets30.Count}");

            transactions.Add($" sukurta €30 x {input.ToString()} vnt.");

            return tickets30;

        }

        public static void Sell()
        {

            Console.WriteLine("[2] Parduoti bilietus -> [1] Po €10");
            Console.WriteLine("                         [2] Po €20");
            Console.WriteLine("                         [3] Po €30");
            int input = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (input)
            {
                case 1:
                    SellTickets10();
                    break;
                case 2:
                    SellTickets20();
                    break;
                case 3:
                    SellTickets30();
                    break;
            }
        }

        public static List<int> SellTickets10()
        {
            Console.WriteLine("[2] Parduoti bilietus -> [1] Po €10 -> [Skaičius] ");
            Console.WriteLine("                         [2] Po €20");
            Console.WriteLine("                         [3] Po €30");
            int input = int.Parse(Console.ReadLine());
            Console.Clear();

            for (int i = 0; i < input; i++)
            {
                sold10.Add(i);
            }
            Console.WriteLine($"[1] Kurti bilietus -> [1] Po €10 -> [Skaičius] -> parduota {input} vnt., esamas {TicketBalance()}: {tickets10.Count - sold10.Count} vnt.");
            Console.WriteLine("                      [2] Po €20");
            Console.WriteLine("                      [3] Po €30");

            transactions.Add($"parduota €10 x {input.ToString()} vnt.");

            return sold10;
        }

        public static List<int> SellTickets20()
        {
            Console.WriteLine("[2] Parduoti bilietus -> [1] Po €10");
            Console.WriteLine("                         [2] Po €20 -> [Skaičius] ");
            Console.WriteLine("                         [3] Po €30");
            int input = int.Parse(Console.ReadLine());
            Console.Clear();

            for (int i = 0; i < input; i++)
            {
                sold20.Add(i);
            }
            Console.WriteLine("[1] Kurti bilietus -> [1] Po €10");
            Console.WriteLine($"                      [2] Po €20 -> [Skaičius] -> parduota {input} vnt., esamas likutis: {tickets20.Count - sold20.Count} vnt.");
            Console.WriteLine("                      [3] Po €30");

            transactions.Add($"parduota €20 x {input.ToString()} vnt.");

            return sold20;
        }

        public static List<int> SellTickets30()
        {
            Console.WriteLine("[2] Parduoti bilietus -> [1] Po €10");
            Console.WriteLine("                         [2] Po €20");
            Console.WriteLine("                         [3] Po €30 -> [Skaičius] ");
            int input = int.Parse(Console.ReadLine());
            Console.Clear();

            for (int i = 0; i < input; i++)
            {
                sold30.Add(i);
            }
            Console.WriteLine("[1] Kurti bilietus -> [1] Po €10");
            Console.WriteLine("                      [2] Po €20");
            Console.WriteLine($"                      [3] Po €30 -> [Skaičius] -> parduota {input} vnt., esamas likutis: {tickets30.Count - sold30.Count} vnt.");

            transactions.Add($"parduota €30 x {input.ToString()} vnt.");

            return sold30;
        }

        public static void Statystics()
        {
            Console.WriteLine($"Bilietų po €10 sukurta: {tickets10.Count} vnt.;");
            Console.WriteLine($"              parduota: {sold10.Count} vnt.;");
            Console.WriteLine($"               likutis: {tickets10.Count - sold10.Count} vnt.;");
            Console.WriteLine("");
            Console.WriteLine($"Bilietų po €20 sukurta: {tickets20.Count} vnt.;");
            Console.WriteLine($"              parduota: {sold20.Count} vnt.;");
            Console.WriteLine($"               likutis: {tickets20.Count - sold20.Count} vnt.;");
            Console.WriteLine("");
            Console.WriteLine($"Bilietų po €30 sukurta: {tickets30.Count} vnt.;");
            Console.WriteLine($"              parduota: {sold30.Count} vnt.;");
            Console.WriteLine($"               likutis: {tickets30.Count - sold30.Count} vnt.;");
        }

        public static void Operations()
        {
            Console.WriteLine("Paskutinės konsolės operacijos: ");
            foreach (var unit in transactions)
            {
                Console.WriteLine(unit);
            }
            Console.WriteLine();
        }

        public static string TicketBalance() // <-- čia reikia praplėsti funkcionalumą
        {
            if (tickets10.Count < 0)
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

