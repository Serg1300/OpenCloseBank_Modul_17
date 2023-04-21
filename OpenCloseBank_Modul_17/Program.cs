namespace OpenCloseBank_Modul_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var accountPhysical = new AccountPhysical
            {
                Balance = 300000,
                Interest = 1000000,
                Type = "Обычный"
            };

            var accountBank = new AccountBank { Name = "Газпромбанк", BalanceOverdraft = 1000000000 };

            var calculator = new Calculator();

            calculator.SolutionCalculator(new CalculatorAccount(accountPhysical));

            Console.WriteLine($" Тип учетной записи: {accountPhysical.Type}\n Баланс учетной записи: {accountPhysical.Balance}\n Процентная ставка: {accountPhysical.Interest}");

            calculator.SolutionCalculator(new CalculatorBank(accountBank));

            Console.WriteLine();    

            Console.WriteLine($" Тип банка: {accountBank.Name}\n Баланс овердрафта: {accountBank.BalanceOverdraft}");


        }
    }
}