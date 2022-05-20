namespace Math_6174;

class SimplifyFunctions
{
    static void Init()
    {
        bool showDetails = true;

        Console.WriteLine(""
            + "*********************************************************************\n"
            + "******   Mathematical Strange Thing  ->  6174 Number           ******\n"
            + "******   Made by Ameaca                                        ******\n"
            + "*********************************************************************\n"
            + "*                                                                   *\n"
            + "*   1 -D- One Value with Details                                    *\n"
            + "*   2 -N- One Value without Details                                 *\n"
            + "*   3 -D- All 4 digits no sorting                                   *\n"
            + "*   4 -N- All 4 digits no sorting                                   *\n"
            + "*   5 -D- All 4 digits sorting steps (Biggest first)                *\n"
            + "*   6 -N- All 4 digits sorting steps (Biggest first)                *\n"
            + "*   7 -D- All 4 digits sorting steps (Lowest first)                 *\n"
            + "*   8 -N- All 4 digits sorting steps (Lowest first)                 *\n"
            + "*   9 - Show Details turn True or False                             *\n"
            + "*   0 - Quit                                                        *\n"
            + "*                                                                   *\n"
            + "*********************************************************************\n"
            + "");

        do {
            ConsoleKey inputMenu = Console.ReadKey().Key;
            Console.WriteLine();
            switch (inputMenu)
            {
                case ConsoleKey.NumPad0:
                    Console.WriteLine("Bye-bye");
                    break;
                case ConsoleKey.NumPad1:

                    break;
                case ConsoleKey.NumPad2:

                    break;
                case ConsoleKey.NumPad3:

                    break;
                case ConsoleKey.NumPad4:

                    break;
                case ConsoleKey.NumPad5:

                    break;
                case ConsoleKey.NumPad6:

                    break;
                case ConsoleKey.NumPad7:

                    break;
                case ConsoleKey.NumPad8:

                    break;
                case ConsoleKey.NumPad9:
                    showDetails = !showDetails;
                    Console.WriteLine($"Show Details is: {showDetails}");
                    break;
                default:
                    Console.WriteLine("ERROR INPUT: Select a valid number");
                    break;
            }
        } while (true);
    }












}
