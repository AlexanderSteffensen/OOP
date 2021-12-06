namespace DashSystem.Core.Transactions
{
    public interface ITransaction
    {
        public string ToString();

        public void Execute();
    }
}