namespace NameAndAgeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declaring variables
            char cUserChoice = ' ';
            String sName = String.Empty, sAge = String.Empty;
            while (true)
            {
                // welcome message 
                WelcomeApp("print name and age on the screen");
                // Ask user to enter his/her name, and read it
                ReadString("name", out sName);
                // Ask user to enter his/her age, and read it
                ReadString("age", out sAge);
                // print the output
                Print($"Hello {sName}, you are {sAge} years old.");

                // to read user choice to continue in the app again and validate the user input
                if (!IsChar(" y to check another number else enter n", out cUserChoice))
                    return;
                // convert the character to lower 
                cUserChoice = Char.ToLower(cUserChoice);
                // to check the user input in the right format (y,n)
                if (!IsInRightFormat(cUserChoice))
                    return;
                // to check if the user want to continue or not
                if (!WantToContinue(cUserChoice))
                    return;
            }
        }

        #region app-methods

        // 1) this method to welcome user in the beginning of the application
        static void WelcomeApp(String welcomeMessage)
        {
            Console.Clear();
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine($"  Welcome to {welcomeMessage} Application!");
            Console.WriteLine("  This app is designed to make your life easier.");
            Console.WriteLine("  Let's get started!");
            Console.WriteLine("  Developed by: Mohammed Salem");
            Console.WriteLine("*********************************************************************************");
        }

        // 2) this method to print message in a beatiful form
        static void Print(String message)
        {
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.WriteLine(message);
            Console.WriteLine("---------------------------------------------------------------------------------");
        }

        // 3) this method to read a string from user
        static void ReadString(string field, out string value)
        {
            Console.Write($"Please enter the {field}: ");
            value = Console.ReadLine();
        }

        // 4) this method to read and validate character from the user
        static bool IsChar(string field, out char character)
        {
            Console.Write($"Please, enter {field}: ");
            if (!char.TryParse(Console.ReadLine(), out character))
            {
                Print("Please, enter a valid character");
                return false;
            }
            return true;
        }

        // 5) this method to check that the user entered (y,n) only
        static bool IsInRightFormat(char input)
        {
            if (input == 'y' || input == 'n')
                return true;
            Print("Please, enter (y) to continue in the application again else enter (n)");
            return false;
        }

        // 6) this method to check the user choice if he wants to continue in the app or not
        static bool WantToContinue(char input)
        {
            if (input == 'y')
                return true;
            Print("The program ended : see you soon again");
            return false;
        }

        #endregion
    }
}

