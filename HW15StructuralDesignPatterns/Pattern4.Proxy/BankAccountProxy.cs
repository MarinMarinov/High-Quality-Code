using System;

namespace Pattern4.Proxy
{
    public class BankAccountProxy : IBankAccount
    {
        private readonly bool userIsAuthorized;

        private IBankAccount activeAccount;

        public BankAccountProxy(string userName, string password)
        {
            //Doing all validations needed
            if (userName != null && password != null)
            {
                this.userIsAuthorized = true;
            }
        }

        public bool Deposit(decimal amount)
        {
            if (!CheckIfUserIsAuthorized())
            {
                return false;
            }
                      
            CheckIfAccountIsActive();

            if (!ValidateDepositeAmount(amount))
            {
                return false;
            }

            this.activeAccount.Deposit(amount);            

            return true;
        }

        public bool Withdraw(decimal amount)
        {
            // Do validations
            if (this.activeAccount.GetCurrentBalance() <= 0 || this.activeAccount == null)
            {
                Console.WriteLine("The Ballance of your account is 0");

                return false;
            }
            if ((this.activeAccount.GetCurrentBalance() - amount) < 0)
            {
                Console.WriteLine("Your Balance is too low for this withdraw");

                return false;
            }

            this.activeAccount.Withdraw(amount);

            return true;
        }

        private bool CheckIfUserIsAuthorized()
        {
            if (this.userIsAuthorized)
            {
                return true;
            }

            return false;
        }

        private void CheckIfAccountIsActive()
        {
            if (this.activeAccount == null)
            {
                this.activeAccount = new BankAccount();
            }
        }

        private bool ValidateDepositeAmount(decimal amount)
        {
            if (amount < 10)
            {
                Console.WriteLine("Minimum deposite amount is 10 units");

                return false;
            }
            if (amount > 10000)
            {
                Console.WriteLine("Maximum deposite amount is 10 000 units");

                return false;
            }

            return true;
        }

        public decimal GetCurrentBalance()
        {
            CheckIfAccountIsActive();

            return this.activeAccount.GetCurrentBalance();
        }
    }
}
