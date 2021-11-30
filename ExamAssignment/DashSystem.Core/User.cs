using System;
using System.Text.RegularExpressions;

namespace ExamAssignment
{
    public class User : IComparable<User>
    {
        public User(int id, string firstname, string lastname, string username, decimal balance, string email)
        {
            ID = id;
            Firstname = firstname;
            Lastname = lastname;
            Username = username;
            Email = email;
            Balance = balance;
        }

        private int ID;
        private string _firstname;

        public string Firstname
        {
            get
            {
                return _firstname;
            }
            private set
            {
                if (value == null)
                {
                    throw new Exception("Firstname cannot be null!");
                }
                else
                {
                    _firstname = value;
                }
            }
        }

        private string _lastname;

        public string Lastname
        {
            get
            {
                return _lastname;
            }
            private set
            {
                if (value == null)
                {
                    throw new Exception("Lastname cannot be null!");
                }
                else
                {
                    _lastname = value;
                }
            }
        }

        private string _username;

        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                Regex usernameValidation = new Regex(@"^([a-z0-9_]+)$");
                if (usernameValidation.   IsMatch(value))
                {
                    _username = value;
                }
                else
                {
                    throw new ArgumentException("Not a valid username");
                }
            }
        }

        private string _email;
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                Regex emailValidation = new Regex(@"^([A-Za-z0-9_\.\-]+)@[^\-\.]([A-Za-z0-9_\.\-]+)\.([A-Za-z0-9_\.\-]+)[^\-\.]$");
                if (emailValidation.IsMatch(value))
                {
                    _email = value;
                }
                else
                {
                    throw new Exception("The mail is not validated");
                }
            }
        }

        public decimal Balance { get; set; }

        public void UserBalanceNotification(User user, decimal balance)
        {
            // TODO: Når brugerens saldo går under 50 kroner skal brugeren advares, og ved yderligere køb bliver der vist en advarselsbesked. Introducér et deleegate til denne slags hændelser
        }

        public int CompareTo(User other)
        {
            if (this.ID < other.ID)
                return -1;
            
            return this.ID > other.ID ? 1 : 0;
        }

        public override string ToString()
        {
            return Firstname + " " + Lastname + " (" + Email + ")";
        }

        public override bool Equals(Object obj)
        {
            if (obj.GetHashCode() == this.GetHashCode())
                return true;
            
            return false;
        }

        public override int GetHashCode()
        {
            return Username.GetHashCode();
        }
    }
}