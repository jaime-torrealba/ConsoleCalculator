namespace ConsoleCalculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool keeplooping = true;

            while (keeplooping)
            {
                Console.Clear();

                PrintMenu();

                int userPick = AskUserForNumber("menu selection");

                switch (userPick)
                {
                    case 1:
                        for (int i = 3; i > 0; i--)
                        {
                            Console.WriteLine("Counting down: " + i);
                        }
                        break;

                    case 2:
                        CodeLove();
                        break;
                    case 3:
                        GreatUser();
                        break;
                    case 4:
                        TheBar();
                        break;
                    case 9:
                        keeplooping = false;
                        break;
                    default:
                        Console.WriteLine("Not a valid option");
                        break;
                }

                Console.WriteLine("Press any key to continue");
                Console.ReadKey();

            } //end of while loop


            // End of Main method

            static void PrintMenu()
            {
                Console.WriteLine("----- Menu -----");
                Console.WriteLine("1: Count down from 3");
                Console.WriteLine("2: Give me code love");
                Console.WriteLine("3: Great user");
                Console.WriteLine("4: The bar");
                Console.WriteLine("9: Exit the program");
            }

            static string AskUserFor(string what)
            {
                Console.Write("Please enter " + what + ": ");
                /*Console.Write("Please enter {0}: ", what);
                  Console.WriteLine($"Please enter {what}: "); */
                Console.ReadLine();
            }

            static int AskUserForNumber(string what)
            {
                string imputed = AskUserFor(what);

                int number = Convert.ToInt32(imputed);

                return number;
            }

            static void CodeLove()
            {
                int amount = AskUserForNumber("How much code love do you need?");

                while (amount > 0);
                {
                    Console.WriteLine("Code loves you!");
                    amount--;
                }
            }

            static void GreatUser()
            {
                //string userName = Console.ReadLine();
                string userName = AskUserFor("your name");

                Console.WriteLine("Hello " + userName);
            }

            static void TheBar()
            {
                //int userAge = Convert.ToInt32( AskUserFor("your age") );
                int userAge = AskUserForNumber("your age");

                if (userAge > 17)
                {
                    Console.WriteLine("Do you want a beer?");
                }
                else
                {
                    Console.WriteLine("Do you want a soda?");
                }

            }
        }
    }
}
    





//Console.Write("");      //Writes to the console

//Console.WriteLine("");    //Writes a line to the console, adding a line break

//Console.ReadLine();    //Reads text imput from console

//Console.ReadKey();        //Reads a keypress from user

//Console.Clear();       //Clears the console-window
