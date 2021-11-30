namespace ExamAssignment
{
    public interface ITransaction
    {
        public string ToString();

        public void Execute();
    }
}