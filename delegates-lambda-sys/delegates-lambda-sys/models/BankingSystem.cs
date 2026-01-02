namespace SeventeenthConsoleApp.models
{
    internal class BankingSystem
    {
        public decimal Balance { get; set; }

        public void ShowBalance()
        {
            Console.WriteLine("=======================================");
            Console.WriteLine($"   Current Balance: {Balance}");
            Console.WriteLine("=======================================");
        }

        public void DepositMoney(decimal amount)
        {
            ArgumentOutOfRangeException.ThrowIfNegativeOrZero(amount);
            Balance += amount;
        }

        public void WithdrawMoney(decimal amount)
        {
            ArgumentOutOfRangeException.ThrowIfGreaterThan(amount, Balance);
            Balance -= amount;
        }
    }
}
