namespace Pattern4.Proxy
{
    public class BankAccount : IBankAccount
    {
        public BankAccount()
        {
            this.Ballance = 0;
        } 
        
        private decimal Ballance { get; set; }

        public bool Deposit(decimal amount) // not the best idea to break Single Responsibility principle, but for the example is appropriate
        {
            this.Ballance += amount;

            return true;
        }

        public bool Withdraw(decimal amount)
        {
            this.Ballance -= amount;

            return true;
        }

        public decimal GetCurrentBalance()
        {
            return this.Ballance;
        }
    }
}
