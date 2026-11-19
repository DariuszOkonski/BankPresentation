namespace BankPresentation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Bank Presentation =====");
            Console.WriteLine(":: Login Page::");

            string userName = null;
            string password = null;

            Console.Write("Username: ");
            userName = Console.ReadLine();

            if (userName != "")
            {
                Console.Write("Password: ");
                password = Console.ReadLine();
            }

            if (userName == "system" && password == "manager")
            {
                int mainMenuChoice = -1;
                do
                {

                    Console.WriteLine("TODO: Main menu here");
                    Console.WriteLine("1.Customers");
                    Console.WriteLine("2.Accounts");
                    Console.WriteLine("3.Funds Transfer");
                    Console.WriteLine("4.Funds Transfer Statement");
                    Console.WriteLine("5.Account Statement");
                    Console.WriteLine("0.Exit");

                    Console.Write("Enter choice:");
                    mainMenuChoice = int.Parse(Console.ReadLine());

                    switch (mainMenuChoice)
                    {
                        case 1:
                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                        case 5:
                            break;
                        default:
                            break;
                    }

                    Console.ReadKey();
                    Console.Clear();

                } while (mainMenuChoice != 0);
            }
            else
            {
                Console.WriteLine("INvalid username or password");
            }

            Console.WriteLine("Thank you! Visit again");
        }
    }
}
