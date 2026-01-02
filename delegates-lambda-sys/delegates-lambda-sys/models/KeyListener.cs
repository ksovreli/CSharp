namespace SeventeenthConsoleApp.models
{
    internal class KeyListener
    {
        public event Action OnBalanceCheck = null!;
        public event Action<decimal> OnWithdrawMoney = null!;
        public event Action<decimal> OnDepositMoney = null!;

        public void StartListening()
        {
            Console.WriteLine("=======================================");
            Console.WriteLine("         WELCOME TO YOUR BANK          ");
            Console.WriteLine("=======================================");

            while (true)
            {
                Console.WriteLine("\n---------------------------------------");
                Console.WriteLine("Choose an action:");
                Console.WriteLine("[B] Show Balance");
                Console.WriteLine("[D] Deposit Money");
                Console.WriteLine("[W] Withdraw Money");
                Console.WriteLine("[ESC] Exit");
                Console.WriteLine("---------------------------------------");

                var x = Console.ReadKey(true);

                if (x.Key == ConsoleKey.Escape)
                {
                    Console.WriteLine("\nYou have exited the program.\n");
                    break;
                }

                switch (x.Key)
                {
                    case ConsoleKey.W:
                        Console.Write("\nEnter amount to withdraw: ");
                        decimal withdrawAmount = Convert.ToDecimal(Console.ReadLine());
                        OnWithdrawMoney?.Invoke(withdrawAmount);
                        Console.WriteLine($"Withdrawn: {withdrawAmount}");
                        break;

                    case ConsoleKey.B:
                        OnBalanceCheck?.Invoke();
                        break;

                    case ConsoleKey.D:
                        Console.Write("\nEnter amount to deposit: ");
                        decimal depositAmount = Convert.ToDecimal(Console.ReadLine());
                        OnDepositMoney?.Invoke(depositAmount);
                        Console.WriteLine($"Deposited: {depositAmount}");
                        break;

                    default:
                        Console.WriteLine("\nInvalid option. Try again!");
                        break;
                }
            }
        }
    }
}
