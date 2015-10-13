using System;
namespace Pattern4.Proxy
{
    public class Program
    {
        public static void Main()
        {
            // Working with BankAccount class
            IBankAccount account = new BankAccount();
            Console.WriteLine(account.GetCurrentBalance()); //0
            account.Deposit(1234.67m);
            account.Withdraw(10000.00m);
            Console.WriteLine(account.GetCurrentBalance()); // -8765.33 => Unproper behavior

            //Working with BankAccountProxy class
            IBankAccount proxyAccount = new BankAccountProxy("Ivan Petrov", "very secret password");
            Console.WriteLine(proxyAccount.GetCurrentBalance()); //0

            proxyAccount.Deposit(5m); // Minimum deposite amount is 10 units
            proxyAccount.Deposit(10001m); //Maximum deposite amount is 10 000 units
            Console.WriteLine(proxyAccount.GetCurrentBalance()); // 0

            proxyAccount.Withdraw(100m); // The Ballance of your account is 0

            proxyAccount.Deposit(1234.56m);
            proxyAccount.Withdraw(1000.00m);
            Console.WriteLine(proxyAccount.GetCurrentBalance()); // 234.56

            proxyAccount.Withdraw(234.57m); // Your Balance is too low for this withdraw     
        }
    }
}
