using System;

namespace ExamAssignment
{
    public class User : IComparable<int>
    {
        public User(int id, string firstname, string lastname, string username, string email)
        {
            ID = id;
            Firstname = firstname;
            Lastname = lastname;
            Username = username;
            Email = email;
        }

        private int ID;
        private string Firstname;
        private string Lastname;
        private string Username;
        private string Email;
        public decimal Balance { get; set; }

        public void UserBalanceNotification(User user, decimal balance)
        {
            
        }

        public int CompareTo(int other)
        {
            
                throw new NotImplementedException();
            
        }

        public string ToString()
        {
            return Firstname + " " + Lastname + " (" + Email + ")";
        }
        
        

    }
}