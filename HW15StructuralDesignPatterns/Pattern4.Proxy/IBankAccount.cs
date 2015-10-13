namespace Pattern4.Proxy
{
    public interface IBankAccount
    {
        bool Deposit(decimal amount);

        bool Withdraw(decimal amount);

        decimal GetCurrentBalance();
    }
}
