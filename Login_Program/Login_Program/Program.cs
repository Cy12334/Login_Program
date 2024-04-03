namespace SuperLola
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            int attempts = 3;

            while (attempts > 0)

            {
                Console.Write("Enter your username: ");
                string username = Console.ReadLine();

                if (username == "Admin")
                {
                    Console.Write("Enter your password: ");
                    string password = Console.ReadLine();

                    if (password == "Admin1234!")
                    {
                        Console.WriteLine(" login susccessful");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("WRONG PASSWORD");
                    }
                }
                else
                {
                    Console.WriteLine("WRONG USERNAME");
                }
                attempts--;
                Console.WriteLine($"only {attempts} attemps.");
            }
            Console.WriteLine("no more attempts for you");
        }

    }

}