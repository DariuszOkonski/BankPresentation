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
                Console.WriteLine("TODO: Main menu here");
            }

            Console.WriteLine("Thank you! Visit again");


        }
    }
}
