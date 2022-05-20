namespace Math6174
{
    class Math_6174
    {
        static readonly string copyRights = "*********************************************************************************\n" +
                                            "******   Mathematical Strange Thing  ->  6174 Number                       ******\n" +
                                            "******   Made by Ameaca                                                    ******\n" +
                                            "*********************************************************************************\n";

        static readonly string menuString =   "1 -D- One Value with Details\n"
                                            + "2 -N- One Value without Details\n"
                                            + "3 -D- All 4 digits no sorting\n"
                                            + "4 -N- All 4 digits no sorting\n"
                                            + "5 -D- All 4 digits sorting steps (Biggest first)\n"
                                            + "6 -N- All 4 digits sorting steps (Biggest first)\n"
                                            + "7 -D- All 4 digits sorting steps (Lowest first)\n"
                                            + "8 -N- All 4 digits sorting steps (Lowest first)\n"
                                            + "9 - All Exporting Data\n"
                                            + "0 - Quit";


        static int Is4DigitInterger(string s)
        {
            if (string.IsNullOrEmpty(s)) { return 0; }

            int n = int.TryParse(s, out n) ? n >= 1000 && n <= 9999 ? n : 0 : 0;
            return n;
        }
        static bool IsPossibleValue(int n)
        {
            if (n == 1000) { return false; }
            int[] sep = SeparateInterger(n);
            if (sep[0] == sep[1] && sep[0] == sep[2] && sep[0] == sep[3]) { return false; }
            return true;
        }
        static int[] SeparateInterger(int n)
        {
            int[] sep = new int[4];

            sep[3] = n % 10;
            n /= 10;
            sep[2] = n % 10;
            n /= 10;
            sep[1] = n % 10;
            n /= 10;
            sep[0] = n;

            return sep;
        }
        static int EnterValue()
        {
            int n;
            do
            {
                string? s = Console.ReadLine()?.Trim();
                n = Is4DigitInterger(s);
                if (n == 0) { Console.WriteLine("ERROR INPUT: Is not an 4 digit interger"); }
                if (!IsPossibleValue(n)) { Console.WriteLine("ERROR VALUE: The value enterred is a non working value"); }
            } while (n == 0 || !IsPossibleValue(n));

            return n;
        }
        static int GetHigher(int value)
        {
            int[] vs = SeparateInterger(value);

            for (int i = 0; i < 4; i++)
            {
                for (int k = 0; k < 3; k++)
                {
                    if (vs[k] < vs[k + 1])
                    {
                        (vs[k + 1], vs[k]) = (vs[k], vs[k + 1]);
                    }
                }
            }

            int v = vs[3] + vs[2] * 10 + vs[1] * 100 + vs[0] * 1000;
            return v;
        }
        static int GetLower(int value)
        {
            int[] vs = SeparateInterger(value);

            for (int i = 0; i < 4; i++)
            {
                for (int k = 0; k < 3; k++)
                {
                    if (vs[k] > vs[k + 1])
                    {
                        (vs[k + 1], vs[k]) = (vs[k], vs[k + 1]);
                    }
                }
            }

            int v = vs[3] + vs[2] * 10 + vs[1] * 100 + vs[0] * 1000;
            return v;
        }
        static int Menu()
        {
            do
            {
                Console.WriteLine(menuString);
                ConsoleKey key = Console.ReadKey().Key;
                Console.WriteLine();
                switch (key)
                {
                    case ConsoleKey.NumPad0: return 0;
                    case ConsoleKey.NumPad1: return 1;
                    case ConsoleKey.NumPad2: return 2;
                    case ConsoleKey.NumPad3: return 3;
                    case ConsoleKey.NumPad4: return 4;
                    case ConsoleKey.NumPad5: return 5;
                    case ConsoleKey.NumPad6: return 6;
                    case ConsoleKey.NumPad7: return 7;
                    case ConsoleKey.NumPad8: return 8;
                    case ConsoleKey.NumPad9: return 9;
                }
                Console.WriteLine("ERROR INPUT: Select a valid number");
            } while (true);
        }

        static int[,] SortingData(int[,] data)
        {
            
        }


        static void OneValue(bool show)
        {
            Console.Write("Select a 4 digit integer: ");
            int n = EnterValue(), iteration = 0;
            int startNumber = n;
            while (n != 6174)
            {
                iteration++;
                int high = GetHigher(n);
                int low = GetLower(n);
                n = high - low;
                if (show) { Console.WriteLine($"{iteration,2} => Higher: {high,4}, Lower: {low,4} = Value {n,4}"); }
                
            }
            Console.WriteLine($"Number: {startNumber,4} -> {iteration,2}\n");
        }
        static void MultiValueNoSorting(bool show)
        {
            int n = 1001, startNumber = n;
            
            while ( startNumber < 9999)
            {
                int iteration = 0;
                n = startNumber;
                if (!IsPossibleValue(n)) 
                { 
                    Console.WriteLine($"Number: {n,4} -> can't be calculate (is an exception)"); 
                    startNumber++;
                    continue;
                } // Verify if is a possible number (1542=OK | 5555=NO)

                while (n != 6174 )
                {
                    if (iteration > 99) return;
                    iteration++;
                    int high = GetHigher(n);
                    int low = GetLower(n);
                    n = high - low;
                    if (show) { Console.WriteLine($"{iteration,2} => Higher: {high,4}, Lower: {low,4} = Value {n,4}"); }
                }
                if (show) { Console.WriteLine($"Number: {startNumber,4} -> {iteration,2}\n"); }
                else { Console.WriteLine($"Number: {startNumber,4} -> {iteration,2}"); }
                startNumber++;
            }
        }
        static void MultiValueSortingBig(bool show)
        {
            int[,] data = new int[9000, 2];
            int n = 1001, startNumber = n;

            while (startNumber < 9999)
            {
                int iteration = 0;
                n = startNumber;
                if (!IsPossibleValue(n))
                {
                    Console.WriteLine($"Number: {n,4} -> can't be calculate (is an exception)");
                    iteration = -1;
                    startNumber++;
                    continue;
                } // Verify if is a possible number (1542=OK | 5555=NO)

                while (n != 6174)
                {
                    if (iteration > 99) return;
                    iteration++;
                    int high = GetHigher(n);
                    int low = GetLower(n);
                    n = high - low;
                    if (show) { Console.WriteLine($"{iteration,2} => Higher: {high,4}, Lower: {low,4} = Value {n,4}"); }
                }
                data[startNumber - 1001, 0] = startNumber;
                data[startNumber - 1001, 1] = iteration;
                if (show) { Console.WriteLine($"Number: {startNumber,4} -> {iteration,2}\n"); }
                else { Console.WriteLine($"Number: {startNumber,4} -> {iteration,2}"); }
                startNumber++;
            }




        }
        
        static void Main()
        {

            Console.WriteLine(copyRights);
            int menu = Menu();
            switch (menu)
            {
                case 0: 
                    Console.WriteLine("Bye"); 
                    return;
                case 1:
                    OneValue(true);
                    break;
                case 2:
                    OneValue(false);
                    break;
                case 3:
                    MultiValueNoSorting(true);
                    break;
                case 4:
                    MultiValueNoSorting(false);
                    break;
                case 5:

                    break;
                case 6:

                    break;
                case 7:

                    break;
                case 8:

                    break;
                case 9:

                    break;
            }
        }
    }
}